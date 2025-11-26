namespace ServidorDeArquivos
{
    
    public partial class TelaPrincipal : Form
    {
        public Task tarefa;
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbPasta.Text = FTServer.pastaReceptora;
            FTServer.ListaMensagem = lbLog;
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            int porta = (int)nPorta.Value;
            string endIP = txbEndereco.Text;

            try
            {
                FTServer.enderecoIP = endIP;
                FTServer.portaHost = porta;

                tarefa = Task.Run(() => 
                {
                    FTServer.IniciarServidor();
                } );
            }
            catch (Exception ex)
            {
                lbLog.Invoke(new Action(() => 
                {
                    lbLog.Items.Add("Erro ao conectar: " + ex.Message);
                    lbLog.SetSelected(lbLog.Items.Count - 1, true);
                }));
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch ( Exception ex )
            {
                lbLog.Invoke(new Action(() =>
                {
                    lbLog.Items.Add("Erro ao Parar o Servidor: " + ex.Message);
                    lbLog.SetSelected(lbLog.Items.Count - 1, true);
                }));
            }
        }

        private void lbPasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                FTServer.pastaReceptora = dialog.SelectedPath + @"\";
                lbPasta.Text = FTServer.pastaReceptora;
            }
        }
    }
}
