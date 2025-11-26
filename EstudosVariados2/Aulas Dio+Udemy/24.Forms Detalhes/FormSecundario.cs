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

namespace _24.Forms_Detalhes
{
    public partial class FormSecundario : Form
    {
        public FormSecundario()
        {
            InitializeComponent();
        }

        private void btnVoltarP_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new FormMain()));
            t.Start();
        }
    }
}
