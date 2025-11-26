using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25.FormControle
{
    public partial class Form1 : Form
    {
        Label lb1;
        Button btn1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb1 = new Label();
            lb1.Location = new Point(10,10);
            lb1.AutoSize = false;
            lb1.Size = new Size(150, 200);
            lb1.BackColor = Color.White;
            lb1.ForeColor = Color.Black;
            lb1.Font = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            lb1.Text = "Minha Label";
            this.Controls.Add(lb1);

            btn1 = new Button();
            btn1.Location = new Point(100, 230);
            btn1.AutoSize = false;
            btn1.Size = new Size(80, 50);
            btn1.BackColor = Color.AliceBlue;
            btn1.ForeColor = Color.Black;
            btn1.Font = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            btn1.Text = "Meu botão";
            this.Controls.Add(btn1);

            btn1.Click += btn1Click;
        }

        private void btn1Click(object sender, EventArgs e)
        {
            lb1.Text = "Clicou no meu botão";
        }

    }
}
