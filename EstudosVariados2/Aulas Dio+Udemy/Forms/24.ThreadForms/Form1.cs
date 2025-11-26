using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForms
{
    public partial class Form1 : Form
    {
        private delegate void AtualizarControle(Control controle, String propiedade, object valor);

        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(Tarefa);
            t.IsBackground = true;
        }


        

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            /*if (!t.IsAlive)
            {
                t.Start();
            }*/

            Thread t = new Thread(TarefaFacil);
            t.IsBackground = true; // Fecha junto com o app
            t.Start();
        }

        private void Tarefa()
        {
            while (true)
            {
                DefinirValores(lbResultado, "Text", DateTime.Now.Second.ToString());
                Thread.Sleep(1000);
            }
        }

        //Modo mais simples, sem criar o método ou o delegate

        private void TarefaFacil()
        {
            while (true)
            {
                lbResultado.Invoke(new Action(() =>
                {
                    lbResultado.Text = DateTime.Now.Second.ToString();
                }));

                Thread.Sleep(1000);
            }
        }


        private void DefinirValores(Control controle, string propiedade, object valor)
        {
            if (controle.InvokeRequired)
            {
                AtualizarControle d = new AtualizarControle(DefinirValores);
                controle.Invoke(d, new object[] { controle, propiedade, valor });
            }
            else
            {
                 Type t = controle.GetType();
                PropertyInfo[] propiedades = t.GetProperties();

                foreach (PropertyInfo p in propiedades)
                {
                    if (p.Name.ToUpper() == propiedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);
                    }
                }

            }
        }
    }
}
