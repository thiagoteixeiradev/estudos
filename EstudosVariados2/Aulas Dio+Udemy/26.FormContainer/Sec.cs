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
    public partial class Sec : Form
    {
        public Sec(Form Parent)
        {
            InitializeComponent();

            MdiParent = Parent;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Terc terc = new Terc(MdiParent);
            terc.Show();
            Close();
        }
    }
}
