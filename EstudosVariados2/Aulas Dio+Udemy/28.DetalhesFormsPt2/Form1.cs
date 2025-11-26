using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28.DetalhesFormsPt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //adicionando itens no combobox
            //cbCombo.Items.Add("Moto");
            //Adicionando uma coleção
            cbCombo.Items.AddRange(new object[] {"Cavalo", "Bike", "Moto", "Carro" });
        
            ListViewItem item1 = new ListViewItem("Romario");
            item1.SubItems.Add("83 9 9999-9999");
            item1.SubItems.Add("email@mail.com");

            ListViewItem item2 = new ListViewItem("Gabriel");
            item2.SubItems.Add("83 9 88888-9999");
            item2.SubItems.Add("email@bola.com");

            ListViewItem item3 = new ListViewItem("Logan");
            item3.SubItems.Add("83 9 1010-9999");
            item3.SubItems.Add("qualquer@mail.com");

            ListViewItem item4 = new ListViewItem(new string[] {"Diogo","83 1 1111-1111", "bolinha@bolinha" });

            lista.Items.Add(item1);
            lista.Items.Add(item2);
            lista.Items.Add(item3);
            lista.Items.Add(item4);

        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            if (cbCombo.SelectedItem != null)
            {
                MessageBox.Show("Index: " + cbCombo.SelectedIndex + " Item: " + cbCombo.SelectedItem.ToString());
            }
            else { MessageBox.Show("Selecione um item!"); }
        }

        private void btnPegaData_Click(object sender, EventArgs e)
        {
            string data = dtpCalendario.Value.ToString("dd/MM/yyyy");
            MessageBox.Show(data);
        }

        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void btnDeletarItem_Click(object sender, EventArgs e)
        {
            lista.Items.Remove(lista.SelectedItems[0]);
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Seja bem vindo: " + lista.SelectedItems[0].Text);
        }

        private void btnPegaData2_Click(object sender, EventArgs e)
        {
            DateTime data2 = Calendario.TodayDate;
            MessageBox.Show(data2.Day + "/" + data2.Month + "/" + data2.Year);
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(Calendario.TodayDate.ToString());
        }

        private void nNumeros_ValueChanged(object sender, EventArgs e)
        {
            lbNumero.Text = nNumeros.Value.ToString();

            if(nNumeros.Value % 2 == 0)
            {
                lbN2.Text = "Número Par";
            } else { lbN2.Text = "Número Impar"; }
        }
    }
}
