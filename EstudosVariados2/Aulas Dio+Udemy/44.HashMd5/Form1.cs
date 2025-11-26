using System.Security.Cryptography;

namespace _44.HashMd5
{
    public partial class Form1 : Form
    {
        Md5 md5 = new Md5();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriptografa_Click(object sender, EventArgs e)
        {
            txbSaida.Text = md5.retornarMd5(txbEntrada.Text);
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            string objetoArmazenado = txbObjArmazenado.Text;
            string objetoEntrada = txbEntrada.Text;
            bool resultado = md5.CompararMd5(objetoEntrada, objetoArmazenado);

            if (resultado)
            {
                lbResultado.ForeColor = Color.LightGreen;
                lbResultado.Text = "Dados Iguais";
            }
            else
            {
                lbResultado.ForeColor = Color.Red;
                lbResultado.Text = "Dados diferentes";
            }
        }
    }
}
