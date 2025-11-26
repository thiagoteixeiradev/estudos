using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _24.Forms_Detalhes
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSecundario_Click(object sender, EventArgs e)
        {
            FormSecundario fs = new FormSecundario();

            //Esconde a janela principal após abrir outra janela
            //Hide();



            //A janela principal ficara disponivel
            //fs.Show();

            //A janela principal ficará bloqueada
            fs.ShowDialog();

            //outro modo
            //Application.Run(new FormSecundario());

            //Ao finalizar a form secundaria, mostra novamente a principal
            this.Show();

            //Fecha a instancia após abrir outra janela
            //Close();

        }

        private void btnSegundaThread_Click(object sender, EventArgs e)
        {
            //Fechei a instância anterior, para abrir uma nova
            Close();
            //mais um modo de instanciar e abrir a form ( em uma thread)
            Thread t = new Thread(() => Application.Run(new FormSecundario()));
            t.Start();
        }

        private void btnFormNome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNome fn = new FormNome("Romario");
            //fn.Nome = "Romario Braz da Rocha";
            fn.ShowDialog();

            if (fn.Nome != null) 
            {
                lbPrincipal.Text = fn.Nome;
            }

            this.Show();
      
        }

        private void menuNovo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();
        }

        private void mAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSecundario f = new FormSecundario();
            f.ShowDialog();
            Show();
        }

        private void mSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbmDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Romário Braz da Rocha");
        }

        private void sbmVersao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V1");
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenu.SelectedIndex == 0)
            {
                mArquivo.Text = "File";
                mAbrir.Text = "Open";
                mAjuda.Text = "Help";
                menuNovo.Text = "New";
                mSair.Text = "Exit";
                mSobre.Text = "About";
                sbmDev.Text = "Developer";
                sbmVersao.Text = "Version";
            }
            else if (cbMenu.SelectedIndex == 1)
            {
                mArquivo.Text = "Arquivo";
                mAbrir.Text = "Abrir";
                mAjuda.Text = "Ajuda";
                menuNovo.Text = "Novo";
                mSair.Text = "Sair";
                mSobre.Text = "Sobre";
                sbmDev.Text = "Desenvolvedor";
                sbmVersao.Text = "Versão";
            }

        }

        private void txbPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbPrincipal.Text = txbPesquisar.Text;
                txbPesquisar.Text = "";
            }
        }
    }
}
