using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31.TryCatch
{
    public partial class Erros : Form
    {
        public Erros()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int[] numeros = {10, 20, 30, 40, 50};

            string res = "";

            try
            {
                for (int i = 0; i < 6; i++)
                {
                    if (i == numeros.Length - 1)
                    {
                        res += numeros[i] + ". ";
                    }
                    else
                    {
                        res += numeros[i] + ", ";
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                //Meu catch irá me retornar o código do erro que ocorreu.
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                //Meu catch irá me retornar o código do erro que ocorreu.
                MessageBox.Show("Ocorreu um erro Generico: " + ex.Message);
            }

            finally  //O finaly sempre é executado, com erro ou não.
            {
                MessageBox.Show("Operação finalizada.");
            }

            lbResultado.Text = res;
        }
    }
}
