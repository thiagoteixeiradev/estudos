using System;
using System.Drawing;
using System.Security.Cryptography;

namespace _45.CriptoGuardian
{
    public partial class CriptoGuardian : Form
    {

        public CriptoGuardian()
        {
            InitializeComponent();

            Controladora.cspp = new CspParameters();
            Controladora.encrFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Encrypt";
            Controladora.dcrFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Decrypt";
            Controladora.srcFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Resource";


        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            if(Controladora.rsa == null)
            {
                lbResultado.ForeColor = Color.Red;
                lbResultado.Text = "Chave não definida.";
            }
            else
            {
                //escolher arquivo para criptografar
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Controladora.encrFolder;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    //passar o nome + caminho do arquivo
                    string nome = fInfo.FullName;
                    lbResultado.Text = Controladora.EncryptFile(nome);
                }
            }
        }

        private void btnDescript_Click(object sender, EventArgs e)
        {
            if (Controladora.rsa == null)
            {
                lbResultado.ForeColor = Color.Red;
                lbResultado.Text = "Chave não definida.";
            }
            else
            {
                //escolher arquivo para criptografar
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Controladora.srcFolder;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    //passar o nome + caminho do arquivo
                    string nome = fInfo.FullName;
                    lbResultado.Text = Controladora.DecryptFile(nome);
                }
            }
        }

        private void btnCriarChaves_Click(object sender, EventArgs e)
        {
            if(string .IsNullOrEmpty(txbKey.Text))
            {
                lbResultado.ForeColor = Color.Red;
                lbResultado.Text = "Insira um valor para definir a chave pública";
                txbKey.Focus();
                return;
            }

            Controladora.Keyname = txbKey.Text;
            lbResultado.ForeColor = Color.DarkGreen;
            lbResultado.Text = Controladora.CreateAsmKeys();
        }

        private void btnExPublicKey_Click(object sender, EventArgs e)
        {
            if(Controladora.ExportPublicKey())
            {
                lbResultado.ForeColor = Color.DarkBlue;
                lbResultado.Text = "Chave Pública exportada";
            }
            else
            {
                lbResultado.ForeColor = Color.Red;
                lbResultado.Text = "Chave Pública não exportada";
            }
        }

        private void btnInportPublicKey_Click(object sender, EventArgs e)
        {
            Controladora.Keyname = "Publica";
            lbResultado.ForeColor = Color.DarkBlue;
            lbResultado.Text = Controladora.ImportpublicKey();

        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbKey.Text))
            {
                lbResultado.ForeColor = Color.Red;
                lbResultado.Text = "Insira um valor para chave privada";
                txbKey.Focus();
                return;
            }
            
            Controladora.Keyname = txbKey.Text;
            lbResultado.ForeColor = Color.DarkBlue;
            lbResultado.Text = Controladora.GetPrivateKey();
        }
    }
}
