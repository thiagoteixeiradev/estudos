using System.Linq.Expressions;

namespace _47.Lamdba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Expressão lambda: (input - parameters) = > expressão
            //Instrução lambda possuo um bloco como corpo: (input - parameters) = > {expressão}
            Func<int, int> quadrado = x => x * x;

            //lbResultado.Text = "O resultado é: " + quadrado(5);

            Expression<Func<int, int>> ex = x => x + x;

            //lbResultado.Text = ex.ToString();

            //lambdaLinq();

            Action<string> greet = nome =>
            {
                string greeting = $"Olá {nome}!";
                lbResultado.Text = greeting;
            };

            greet("Romário");

            Action<string> line = (nome) => MessageBox.Show(nome);
            line("Romario");
        }

        private void lambdaLinq()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            var numerosQuadrados = numeros.Select(x => x * x);
            MessageBox.Show(string.Join(", ", numerosQuadrados));
        }
    }
}
