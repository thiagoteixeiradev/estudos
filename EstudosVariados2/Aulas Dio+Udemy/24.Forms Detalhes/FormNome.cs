using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24.Forms_Detalhes
{
    public partial class FormNome : Form
    {
        public string Nome { get; set; }

        public FormNome()
        {
            InitializeComponent();
        }

        public FormNome(string nome)
        {
            InitializeComponent();

            Nome = nome;
        }

        private void FormNome_Load(object sender, EventArgs e)
        {
            txbNome.Text = Nome;
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNome.Text))
            {
                Nome = null;
            }
            else
            {
                Nome = txbNome.Text;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
