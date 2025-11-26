namespace _48.CapturarTeclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Select();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            lbMain.Text = "Clicou na tecla X";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lbMain.Text = "Clicou na tecla x";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                lbMain.Text = "Clicou na tecla Enter";
            }
        }

        private void btnX_Click_1(object sender, EventArgs e)
        {
            lbMain.Text = "Clicou na tecla x";
        }
    }
}
