using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27.DetalhesForms
{
    public partial class btnRemoverTudo : Form
    {
        public btnRemoverTudo()
        {
            InitializeComponent();
        }

        private void lbNome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja muito bem vindo: " + lbNome.Text);
        }

        private void lbNome_MouseEnter(object sender, EventArgs e)
        {
            lbNome.Location = new Point(200, 9);
        }

        private void lbNome_MouseLeave(object sender, EventArgs e)
        {
            lbNome.Location = new Point(12, 9);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbNome.Text = txbNomes.Text;
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedItem != null)
            {
                txbNomes.Text = lista.SelectedItem.ToString();
            }
            else
            {
                txbNomes.Clear(); // Opcional: limpa o TextBox quando não há item selecionado
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txbNomes.Text;
            lista.Items.Add(nome);
            txbNomes.Text = "";
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            object item = lista.SelectedItem;
            lista.Items.Remove(item);
            txbNomes.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int quantidade = lista.Items.Count;
            lbNome.Text = $"Você tem {quantidade} itens na sua lista.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ckbGamer.Checked)
            {
                MessageBox.Show("Você é gamer! Parabéns pelo gosto!");
            }
            if (ckbOtaku.Checked)
            {
                MessageBox.Show("Você é Otaku! Parabéns pelo gosto, você toma banho?");
            }
            if (ckbMaromba.Checked)
            {
                MessageBox.Show("E os veneno?");
            }

            if (ckbMaromba.Checked && ckbGamer.Checked)
            {
                MessageBox.Show("Gamer e maromba? Elevou o nível");
            }

            if (ckbMaromba.Checked && ckbOtaku.Checked)
            {
                MessageBox.Show("Otaku e maromba? Elevou o nível");
            }

            if (ckbGamer.Checked && ckbOtaku.Checked)
            {
                MessageBox.Show("Vá checkar se ainda tem namorada/esposa");
            }

            if (!ckbGamer.Checked && !ckbOtaku.Checked && !ckbMaromba.Checked)
            { 
                MessageBox.Show("Você é chato.");
            }
        }

        private void btnCheckListBox_Click(object sender, EventArgs e)
        {
            int qntitembox = listaBox.Items.Count;
            MessageBox.Show("Esta lista tem " + qntitembox + " Itens.");
        }

        private void btnLimparCkb_Click(object sender, EventArgs e)
        {
            listaBox.Items.Clear();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            var selecionados = listaBox.CheckedItems;

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Você não selecionou nenhum item!");
            }

            else
            {

                foreach (var item in selecionados)
                {
                    MessageBox.Show("Você selecionou: " + item.ToString());
                }
            }
        }
    }
}
