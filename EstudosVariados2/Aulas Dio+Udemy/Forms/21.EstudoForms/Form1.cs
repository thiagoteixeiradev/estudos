using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //Vamos captar o retorno do messagebox
            DialogResult res = MessageBox.Show("Texto da mensagem", "Legenda", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            { lbResultado.Text = "Clicou em Sim"; }
            else if (res == DialogResult.No)
            { lbResultado.Text = "Clicou em Não"; }
            else if (res == DialogResult.Cancel)
            { lbResultado.Text = "Clicou em Cancelar"; }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //Vamos captar um random com base nos milesegundos
            Random r = new Random(DateTime.Now.Millisecond);
            int valor = r.Next(1,11);
            // Para obter um double, poderia usar: int valor2 = r.NextDouble(1, 11);
            if (valor == 1) { lbResultado.Text = $"Erro crítico! {valor}"; }
            else if (valor == 10) {lbResultado.Text = $"Acerto crítico! {valor}"; }
            else { lbResultado.Text = valor.ToString(); }
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            //lbResultado.Text = Convert.ToString(TimeSpan.FromDays(35.25));
            //lbResultado.Text = Convert.ToString(TimeSpan.FromTicks(100000));
            //Tick é o menor valor de tempo em que podemos tralhar

            //Ticks em um minuto
            //lbResultado.Text = TimeSpan.TicksPerMinute.ToString();

            // TimeSpan tempo = new TimeSpan(5, 30, 30);// formatar (Horas, Minutos, Segundos)

            //Vamos calcular um espaço de tempo
            TimeSpan inicio = new TimeSpan(17, 0, 0);
            TimeSpan fim = new TimeSpan(18, 30, 0);
            TimeSpan tempo = fim - inicio;
            

            lbResultado.Text = tempo.TotalHours.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            lbResultado.Text = DateTime.Now.ToString("dd-MM-yyyy");
            //no ToString use ("dd-MM-yyyy" HH:mm:ss) para manipular o formato
            // .Now pega data e hora completa
            //Today ignora as horas (completas)
            //.DaysInMonth(Ano, Mes) nos mostra os dias de um determinado ano e mes
            //.IsLeapYear(Ano) verifica se um ano é bisexto ou não, retornando true ou false
            //ToShortDateString Abreia a data, já o long, ele extende (mesmo vale para hour)
            //ToUniversalTime, formatação universal

        }

        private void btnCores_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;
            //Color cor1 = Color.FromArgb(255, amarelo); //setei transparência sob uma cor
            Color cor1 = Color.FromArgb(255, 255, 255, 255);
            //também posso passar apenas (r, g, b) a transparencia sera 255 automaticamente

            Color cor2 = Color.FromKnownColor(KnownColor.MediumPurple);

            Color cor3 = Color.FromName("AliceBlue"); //Por nome de cor conhecida

            lbResultado.ForeColor = vermelho;
            //lbResultado.BackColor = Color.LightBlue; //Posso chamar a cor direto
            lbResultado.BackColor = cor2;

            //Estou pegando a cor de um elemento.
            Color cor4 = lbResultado.BackColor; 

            btnCores.BackColor = cor4;

        }

        private void btnFontes_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);
            Font letra2 = new Font("Comic Sans MS", 26, FontStyle.Regular, GraphicsUnit.Pixel);

            lbResultado.Text = "Estamos alterando as fontes";

            lbResultado.Font = letra2;
        }

        private void btnEnviroment_Click(object sender, EventArgs e)
        {
            //Retorna o caminho de uma pasta pré-determinada "pastas padrões"
            String local = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);

            //Pega o diretório atual
            String dirAtual = Environment.CurrentDirectory;

            //Pegando as variaveis de ambiente
            String varAmb = Environment.GetEnvironmentVariable("Path");

            //Pegando os discos
            string[] discos = Environment.GetLogicalDrives();

            //.UserName : Pega o nome de usuário
            //UserDomainName : Pega o nome do domínio

            //Mostra  a quantidade de processadores
            int cpu = Environment.ProcessorCount;

            foreach (string item in discos) 
            {
                lbResultado.Text += "\n" + item;
            }

            
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            //Finaliza a aplicação
            //Application.Exit();

            //Mostra o caminho e nome da aplicação
            string exec = Application.ExecutablePath;

            //Apenas o caminho da aplicação
            string pasta = Application.StartupPath;
            lbResultado.Text = exec;

            //Reinicia a aplicação
            //Application.Restart();
        }

        private void btnThread_Click(object sender, EventArgs e)
        {

        }
    }
}
