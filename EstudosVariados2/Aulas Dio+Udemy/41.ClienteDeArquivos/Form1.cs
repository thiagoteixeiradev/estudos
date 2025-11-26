namespace _41.ClienteDeArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTCliente.LabelMensagem = lbStatus;
        }

        private void lbArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Enviar Arquivo";
            
            if(ofd.ShowDialog() != DialogResult.Cancel)
            {
                lbArquivo.Text = ofd.FileName;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbIp.Text) || string.IsNullOrEmpty(nPorta.Value.ToString()) || lbArquivo.Text == "Clique Para Selecionar o Arquivo")
            {
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Dados Inválidos";
                return;
            }
            string enderecoIP = lbIp.Text;
            int porta = (int)nPorta.Value;
            string nomeArquivo = lbArquivo.Text;

            FTCliente.enderecoIP = enderecoIP;
            FTCliente.portaHost = porta;

            try
            {
                Task.Run(() =>
                {
                    FTCliente.EnviarArquivo(nomeArquivo);
                });
            }
            catch (Exception ex)
            {
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Erro: " + ex.Message;
            }
            
        }
    }
}
