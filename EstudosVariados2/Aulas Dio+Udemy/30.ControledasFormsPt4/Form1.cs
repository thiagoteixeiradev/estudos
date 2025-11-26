using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30.ControledasFormsPt4
{
    public partial class Form1 : Form
    {
        string txt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImg1_Click(object sender, EventArgs e)
        {
            pbFoto.BackgroundImage = Image.FromFile("Images/1.jpg");
        }

        private void btnImg2_Click(object sender, EventArgs e)
        {
            pbFoto.BackgroundImage = Image.FromFile("Images/2.jpg");
        }

        private void btnImg3_Click(object sender, EventArgs e)
        {
            pbFoto.BackgroundImage = Image.FromFile("Images/3.jpg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void ContextoInicial_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SegundoContexto_Opening(object sender, CancelEventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
        }

        private void recordarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
            textBox1.Text = "";
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt != "" && txt != null)
            {
                textBox2.Text = txt;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invasores tem que morrer!");
            lb1.Text = "Invader!";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Worker.IsBusy)
            {
                Worker.RunWorkerAsync();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Worker.WorkerSupportsCancellation)
            {
                Worker.CancelAsync();
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if(Worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(500);
                    Worker.ReportProgress(i * 10);
                }
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbContador.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Cancelado!");
                lbContador.Text = "Cancelado!";
            }
            else if (e.Error != null)
            {
                lbContador.Text = "Erro:" + e.Error.Message;
            }
            else
            {
                MessageBox.Show("Concluído!");
                lbContador.Text = " 100% Concluído!";
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Olá tudo bem?");
        }

        private void btnConfigurarP_Click(object sender, EventArgs e)
        {
            pgSetup.PageSettings = new System.Drawing.Printing.PageSettings();
            pgSetup.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pgSetup.ShowDialog();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txtp = textBox1.Text;
            Font letra = new Font("Arial", 20, FontStyle.Bold);
            Brush pincel = new SolidBrush(Color.Black);
            e.Graphics.DrawString(txtp, letra, pincel, new PointF(20, 20));
        }

        private void btnImprimir2_Click(object sender, EventArgs e)
        {

                pgSetup.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                pgSetup.PageSettings = new System.Drawing.Printing.PageSettings();

            if (pgSetup.ShowDialog() != DialogResult.Cancel)
            {
                printDocument1.Print();
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Document = printDocument1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void lbCor_Click(object sender, EventArgs e)
        {


        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPastas.ShowDialog();
            MessageBox.Show("O caminho da pasta selecionado foi: " + abrirPastas.SelectedPath.ToString());
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {
            
            if (Fontes.ShowDialog() == DialogResult.OK)
            {
                lbCor.Font = Fontes.Font;
                
            }
        }

        private void abrirArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //filtrar extensão de arquivo
            AbrirArquivo.Filter = "Imagem jpg | *.jpg | PNG | *.png";

            /*
            if (AbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Você selecionou o arquivo: " + AbrirArquivo.FileName.ToString());

            }
            */
            if (AbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in AbrirArquivo.FileNames)
                {
                    MessageBox.Show($"{item}");
                }

            }


        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save.Filter = "Texto | *.txt | Pdf | *.pdf";

            if (Save.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Save.FileName);
            }
        }
    }
}
