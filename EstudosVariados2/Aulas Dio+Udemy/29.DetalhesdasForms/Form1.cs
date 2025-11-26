using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29.DetalhesdasForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcressentar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbar.Value >= 100)
                {
                    MessageBox.Show("Limite atingido, parabéns!");
                }

                else
                {

                    if (btn10.Checked)
                    {
                        pbar.Value += 10;
                    }
                    else if (btn20.Checked)
                    {
                        pbar.Value += 20;
                    }
                    else if (btn30.Checked)
                    {
                        pbar.Value += 30;
                    }
                }
            } 
            catch { MessageBox.Show("Estourou o limite!"); }
                
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selecionado = tv1.SelectedNode.Text;
            MessageBox.Show(selecionado);
        }

        private void btnNavegar_Click(object sender, EventArgs e)
        {
            navegador.Navigate(txbLink.Text);
        }
    }
}
