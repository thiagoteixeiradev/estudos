namespace _46.AsyncExemplo
{
   
    public partial class Form1 : Form
    {
        public static ListBox lstRes;
        public Form1()
        {
            InitializeComponent();
            lstRes = lbResultado;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Add("Evento não foi iniciado: Clique aqui");

            Controladora obj = new Controladora();
            obj.Task_LongaDuracao();

            lbResultado.Items.Add("Evento do botão foi concluído");
        }

        private void btnExecutarAsync_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Add("Evento não foi iniciado: Clique aqui");

            ControladoraAsync obj = new ControladoraAsync();
            obj.Task_LongaDuracao_Async();

            lbResultado.Items.Add("Evento do botão foi concluído");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();
        }
    }
}
