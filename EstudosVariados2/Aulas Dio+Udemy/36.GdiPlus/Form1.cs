using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36.GdiPlus
{
    public partial class Form1 : Form
    {
        public string path = @"D:\\Arquivos\\GitHub\\Estudos.net\\Aulas Dio+Udemy\\36.GdiPlus\\bin\\Debug\\net8.0-windows\\";

        public static Bitmap novaFolha;

        Graphics desenhador;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDesenhar_Click(object sender, EventArgs e)
        {
            //Inicializo minha página no picbox
            novaFolha = new Bitmap(picbImagem.Width, picbImagem.Height);

            //Inicializo meu desenhador
            desenhador = Graphics.FromImage(novaFolha);

            //Desenhar na folha
            desenhador.Clear(Color.WhiteSmoke);

            //Mandei o desenho para o picturebox
            picbImagem.Image = novaFolha;


            //Salvar em arquivo
            novaFolha.Save(path + "Imagem.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        private void btnLinhas_Click(object sender, EventArgs e)
        {
            Pen lapis = new Pen(Color.Black, 5);
            Point p1 = new Point(10, 10);
            Point p2 = new Point(60, 150);
            desenhador.DrawLine(lapis, p1, p2);

            Brush pincel = new SolidBrush(Color.RebeccaPurple);
            Pen lapis2 = new Pen(pincel, 8);
            Point p11 = new Point(40, 40);
            Point p22 = new Point(70, 160);
            desenhador.DrawLine(lapis2, p11, p22);
            //Mandei o desenho para o picturebox
            picbImagem.Image = novaFolha;
        }

        private void btnVariasLinhas_Click(object sender, EventArgs e)
        {
            if (desenhador == null)
            {
                MessageBox.Show("Clique primeiro em 'Desenhar' para criar a folha.");
                return;
            }

            using (Pen lapis = new Pen(Color.Black, 5))
            {
                Point[] pontos1 =
                {
                    new Point(50, 50),
                    new Point(150, 80),
                    new Point(80, 150),
                    new Point(200, 200),
                    new Point(60, 220),
                };

                // Desenha várias linhas conectadas
                desenhador.DrawLines(lapis, pontos1);
            }

            // Atualiza o PictureBox para exibir o novo desenho
            picbImagem.Image = novaFolha;
        }

        private void btnVLina_Click(object sender, EventArgs e)
        {
            if (desenhador == null)
            {
                MessageBox.Show("Clique primeiro em 'Desenhar' para criar a folha.");
                return;
            }

            using (Pen lapis = new Pen(Color.Black, 5))
            {
                Point[] pontos2 =
                {
                    new Point(150, 180),
                    new Point(190, 210),
                    new Point(230, 280),
                    new Point(250, 300),
                };

                // Desenha várias linhas conectadas
                for (int i = 0; i < pontos2.Length - 1; i++)
                {
                    desenhador.DrawLine(lapis, pontos2[i], pontos2[i + 1]);
                }
            }

            // Atualiza o PictureBox para exibir o novo desenho
            picbImagem.Image = novaFolha;
        }

        private void btnRetV_Click(object sender, EventArgs e)
        {
            //Desenhando um retangulo vazio
            Pen lapis = new Pen(Color.MediumVioletRed, 5);

            //criando um objeto retangulo
            Rectangle rect1 = new Rectangle(10, 10, 200, 150);

            desenhador.DrawRectangle(lapis, rect1);
            //também poderia (lapis, xinicio, yinico, xfinal, yfinal)

            desenhador.DrawRectangle(lapis, 30, 30, 150, 200);
            picbImagem.Image = novaFolha;

            //para desenhar varios retangulos posso usar
            //Rectange[] retangulos = { rect1, rect2, rect3...new Rectangle(xi, yi, xf, yf) }
            //desenhador.DrawRectangles(lapis ,retangulos)
        }

        private void btnRetP_Click(object sender, EventArgs e)
        {
            //Desenhando um retangulo Preenchido

            Brush lapis = new SolidBrush(Color.GreenYellow);

            Rectangle rect1 = new Rectangle(10, 10, 200, 150);

            desenhador.FillRectangle(lapis, rect1);

            picbImagem.Image = novaFolha;
        }

        private void btnElipseVazio_Click(object sender, EventArgs e)
        {
            //Desenhando um retangulo vazio
            Pen lapis = new Pen(Color.MediumVioletRed, 5);

            //criando um objeto retangulo
            Rectangle el1 = new Rectangle(10, 10, 200, 150);

            desenhador.DrawEllipse(lapis, el1);
            //também poderia (lapis, xinicio, yinico, xfinal, yfinal)

            desenhador.DrawRectangle(lapis, 30, 30, 150, 200);
            picbImagem.Image = novaFolha;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Desenhando um elipse Preenchido

            Brush lapis = new SolidBrush(Color.GreenYellow);

            Rectangle rect1 = new Rectangle(10, 10, 200, 150);

            desenhador.FillEllipse(lapis, rect1);

            picbImagem.Image = novaFolha;
        }

        private void btnPolV_Click(object sender, EventArgs e)
        {
            //Desenhando um elipse Preenchido

            Pen lapis = new Pen(Color.MediumVioletRed, 5);

            Point[] pontos =
{
                new Point(10, 10),
                new Point(100, 200),
                new Point(200, 300)
            };

            desenhador.DrawPolygon(lapis, pontos);

            picbImagem.Image = novaFolha;
        }

        private void btnPolP_Click(object sender, EventArgs e)
        {
            //Desenhando um elipse Preenchido

            Brush lapis = new SolidBrush(Color.GreenYellow);

            Point[] pontos =
            {
                new Point(10, 10),
                new Point(100, 200),
                new Point(200, 300)
            };

            desenhador.FillPolygon(lapis, pontos);

            picbImagem.Image = novaFolha;
        }

        private void btnCurvaV_Click(object sender, EventArgs e)
        {
            Pen lapis = new Pen(Color.MediumVioletRed, 5);
            Point[] pontos =
            {
                new Point(100, 50),
                new Point(300, 100),
                new Point(500, 200)
            };
            desenhador.DrawCurve(lapis, pontos);
            picbImagem.Image = novaFolha;
        }

        private void btnCurvaP_Click(object sender, EventArgs e)
        {
            Brush lapis = new SolidBrush(Color.GreenYellow);
            Point[] pontos =
            {
                new Point(100, 50),
                new Point(300, 100),
                new Point(500, 200)
            };
            desenhador.FillClosedCurve(lapis, pontos);
            picbImagem.Image = novaFolha;
        }

        private void btnArco_Click(object sender, EventArgs e)
        {
            Pen lapis = new Pen(Color.MediumVioletRed, 5);
            Rectangle rect1 = new Rectangle(10, 10, 200, 150);

            desenhador.DrawArc(lapis, rect1, 45f, 270f);
            picbImagem.Image = novaFolha;
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            Pen lapis = new Pen(Color.MediumVioletRed, 5);
            Point p1 = new Point(50, 300);
            Point p2 = new Point(200, 400);
            Point p3 = new Point(400, 100);
            Point p4 = new Point(500, 200);

            desenhador.DrawBezier(lapis, p1, p2, p3, p4);
            picbImagem.Image = novaFolha;
        }

        private void btnGraficoPie_Click(object sender, EventArgs e)
        {
            Pen lapis = new Pen(Color.MediumVioletRed, 5);
            Rectangle rect1 = new Rectangle(10, 10, 200, 150);
            desenhador.DrawPie(lapis, rect1, 45, 350);
            picbImagem.Image = novaFolha;
        }

        private void btnGPath_Click(object sender, EventArgs e)
        {
            Pen lapis = new Pen(Color.MediumVioletRed, 5);
            GraphicsPath gp = new GraphicsPath(FillMode.Alternate);

            gp.AddEllipse(new Rectangle(10, 10, 100, 150));
            gp.AddEllipse(new Rectangle(5, 5, 200, 300));
            gp.AddRectangle(new Rectangle(15, 15, 100, 150));
            desenhador.DrawPath(lapis, gp);
            picbImagem.Image = novaFolha;
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            Pen lapis = new Pen(Color.MediumVioletRed, 5);
            string texto = "Romario Braz da Rocha";
            Font fonte = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.GreenYellow);
            Point ponto = new Point(10, 10);
            desenhador.DrawString(texto, fonte, pincel, ponto);
            picbImagem.Image = novaFolha;
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            string caminho = Path.Combine(Application.StartupPath, "Imagem", "exemplo.jpg");
            Image img = Image.FromFile(caminho);
            Rectangle rect1 = new Rectangle(0, 0, img.Width, img.Height);
            Rectangle rect2 = new Rectangle(0, 0, img.Width / 5, img.Height / 5);

            desenhador.DrawImage(img, rect1, rect2, GraphicsUnit.Pixel);
            picbImagem.Image = novaFolha;
        }
    }
}
