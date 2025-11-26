using System.Net;

namespace _42.Servidor_de_Chat
{
    public partial class Main : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);
        bool conectado = false;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Application.Exit();
                return;
            }

            if (txbIP.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço IP");
            }

            try
            {
                //analisa o IP do textbox
                IPAddress enderecoIP = IPAddress.Parse(txbIP.Text);
                int portaHost = (int)nPorta.Value;

                //Nova instância do chatServidor
                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                //vinculando o tratamento do status
                Servidor.StatusChanged += mainServidor_StatusChanged;

                //Iniciando as conexões
                mainServidor.IniciaAtendimento();

                //Exibindo as informações no listbox
                lbLog.Items.Add("Servidor Ativo e aberto, os usuários podem se conectar.");
                lbLog.SetSelected(lbLog.Items.Count - 1, true);
            }
            catch (Exception ex) 
            {
                lbLog.Items.Add("Erro de conexão: " + ex.Message);
                lbLog.SetSelected(lbLog.Items.Count - 1, true);
                return;
            }
            conectado = true;
            txbIP.Enabled = false;
            nPorta.Enabled = false;
            btnStart.ForeColor = Color.Red;
            btnStart.Text = "Sair";
        }

        public void mainServidor_StatusChanged(object sender, StatusChangeEvent e)
        {
            //chama e atualiza o formulário
            this.Invoke(new AtualizaStatusCallback(this.atualizaStatus), new object[] { e.EventoMensagem });
        }

        private void atualizaStatus (string strMensagem)
        {
            lbLog.Items.Add(strMensagem);
            lbLog.SetSelected(lbLog.Items.Count - 1, true);
        }
    }
}
