using System.Net;
using System.Net.Sockets;

namespace _43.Client_de_chat
{
    public partial class Client : Form
    {
        //declarando variáveis
        private string nomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        //atualiza o form com a outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        //define o form para desconectado
        private delegate void FechaConexaoCallback(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool Conectado;


        public Client()
        {
            //desconectar ao sair
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "Nome de Usuário")
            {
                MessageBox.Show("Insira seu nome de usuário");
                return;
            }
            //Se não conectado, aguarda conexão
            if (!Conectado)
            {
                //Inicializa conexão
                InicializaConexao();
            }
            else
            {
                //Se conectado, desconecta
                FechaConexao("Desconectado a pedido do usuário");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txbMensagem.Text == "Digite aqui sua mensagem")
            {
                MessageBox.Show("Digite sua mensagem!");
                return;
            }
            else
            {
                EnviaMensagem();
            }

        }

        private void txbMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se pressionou enter
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }

        //Métodos necessários
        private void InicializaConexao()
        {
            try
            {
                //trata o ip
                enderecoIP = IPAddress.Parse(txbIP.Text);
                portaHost = (int)nPorta.Value;
                //iniciando a nova conexão com o servidor
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);
                //Passando status para conectado
                Conectado = true;
                //desabilitando/habilitando campos
                nomeUsuario = txbUserName.Text;
                txbUserName.Enabled = false;
                nPorta.Enabled = false;
                txbIP.Enabled = false;
                btnEnviar.Enabled = true;
                txbMensagem.Enabled = true;
                //alterando botão conectar
                btnStart.ForeColor = Color.Red;
                btnStart.Text = "Desconectar";

                //Enviando nome do usuário
                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(txbUserName.Text);
                stwEnviador.Flush();

                //Inicializando a thread que recebe as mensagens
                mensagemThread = new Thread(new ThreadStart(RecebeMensagens));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                lbStatus.Invoke(new Action(() =>
                {
                    lbStatus.ForeColor = Color.Green;
                    lbStatus.Text = "Conectado";
                }));


            }
            catch (Exception ex)
            {
                lbStatus.Invoke(new Action(() =>
                {
                    lbStatus.ForeColor = Color.Red;
                    lbStatus.Text = "Ocorreu um erro: " + ex.Message;
                }));
            }
        }

        private void RecebeMensagens()
        {
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();
            //se o primeiro char é 1, sucesso.
            if (ConResposta[0] == '1')
            {
                //atualiza o formulario informando da conexão
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });

            }
            else
            {
                //se falhar
                string motivo = "Não conectado: ";
                //pega o motivo
                motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                //Atualiza o formulário informando a falha
                this.Invoke(new FechaConexaoCallback(this.FechaConexao), new object[] { motivo });
                //saindo
                return;
            }

            //enquanto conectado, leia as linhas que chegam do servidor
            while (Conectado)
            {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });


            }
        }

        private void AtualizaLog(string strMensagem)
        {
            //anexa o texto ao final de cada linha
            txbLog.AppendText(strMensagem + "\r\n");
        }

        private void EnviaMensagem()
        {
            if (!string.IsNullOrWhiteSpace(txbMensagem.Text))
            {
                // Envia ao servidor
                stwEnviador.WriteLine(txbMensagem.Text);
                stwEnviador.Flush();

                // Exibe no próprio log do cliente
                AtualizaLog($"Você: {txbMensagem.Text}");

                // Limpa o campo de mensagem
                txbMensagem.Clear();
            }
        }

        private void FechaConexao(string Motivo)
        {
            //Captando o motivo
            txbLog.AppendText(Motivo + "\r\n");
            //desabilitando/habilitando campos
            txbUserName.Enabled = true;
            nPorta.Enabled = true;
            txbIP.Enabled = true;
            btnEnviar.Enabled = false;
            txbMensagem.Enabled = false;
            btnStart.ForeColor = Color.Black;
            btnStart.Text = "Conectar";

            //fechando objetos
            Conectado = false;

            try { stwEnviador?.Close(); } catch { }
            try { strReceptor?.Close(); } catch { }
            try { tcpServidor?.Close(); } catch { }

            lbStatus.Invoke(new Action(() =>
            {
                lbStatus.ForeColor = Color.Green;
                lbStatus.Text = "Desconectado do servidor de chat";
            }));

        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado)
            {
                Conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();

                lbStatus.Invoke(new Action(() =>
                {
                    lbStatus.ForeColor = Color.Green;
                    lbStatus.Text = "Desconectado do servidor de chat";
                }));
            }
        }

        private void txbUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txbUserName.Text = "";
        }

        private void txbMensagem_MouseClick(object sender, MouseEventArgs e)
        {
            txbMensagem.Text = "";
        }
    }
}
