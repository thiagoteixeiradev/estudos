using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26.FormContainer
{
    public partial class Terc : Form
    {
        public Terc(Form Parent)
        {
            InitializeComponent();

            MdiParent = Parent;
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            Sec sec = new Sec(MdiParent);
            sec.Show();
            this.Close();
        }
    }
}
