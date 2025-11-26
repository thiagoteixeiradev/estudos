using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace _37.Imprimindo
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int largura;
        int altura;
        int num_linhas = 0;
        private List<string> linhas;
        int pagina = 0;
        int num_paginas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void PrepararImpressao()
        {
            // Converte o texto em uma lista de linhas antes de iniciar a impressão
            linhas = CampoTexto.Lines.ToList();
            num_linhas = 0; // reseta o contador
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Local do texto que será impresso.
            string texto = CampoTexto.Text;
            //Setando tamanho da folha
            //bounds me da o tamanho da página
            Rectangle area = printDocument1.DefaultPageSettings.Bounds;
            x = area.X;
            y = area.Y;
            altura = area.Height;
            largura = area.Width;

            //fonte
            Font fonte = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);

            //Titulo
            string titulo = "Titulo da página";
            Rectangle areaTitulo = new Rectangle(x + 50, y + 50, largura - 100, 100);
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;


            Rectangle areaTexto = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);
            //Preparando os dados para serem impressos
            e.Graphics.DrawString(titulo, fonte, pincel, areaTitulo, formatoTitulo);
            e.Graphics.DrawString(texto, fonte, pincel, areaTexto);
            e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);
            e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTitulo);

            //e.Graphics.DrawRectangle(new Pen(Color.Red, 5), area);
        }

        private void btnImprimirVarios_Click(object sender, EventArgs e)
        {
            // Prepara os dados antes de iniciar a impressão
            linhas = CampoTexto.Lines.ToList();
            num_linhas = 0;

            printDocument2.Print();
        }


        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle area = e.PageBounds;
            x = area.X + 50; // Margem esquerda
            y = area.Y + 50; // Margem superior
            altura = area.Height;
            largura = area.Width;

            using (Font fonte = new Font("Arial", 20, FontStyle.Bold))
            using (Brush pincel = new SolidBrush(Color.Black))
            {
                while (num_linhas < linhas.Count)
                {
                    e.Graphics.DrawString(linhas[num_linhas], fonte, pincel, new PointF(x, y));
                    y += 30; // Espaço entre linhas
                    num_linhas++;

                    // Se ultrapassar a página, pede nova página
                    if (y >= altura - 50)
                    {
                        e.HasMorePages = true;
                        num_paginas++;
                        return; // Sai para continuar na próxima página
                    }
                }
            }

            // Quando todas as linhas forem impressas
            e.HasMorePages = false;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;
            Visualizador.Document = printDocument1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                Visualizador.StartPage = -- pagina;
            }
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (pagina < num_paginas)
            {
                Visualizador.StartPage = ++ pagina;
            }
        }
    }
}

