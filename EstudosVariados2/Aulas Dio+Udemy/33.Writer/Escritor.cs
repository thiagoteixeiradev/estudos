using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Writer
{
    public partial class Escritor : Form
    {
       public string path = @"D:\\Arquivos\\GitHub\\Estudos.net\\Aulas Dio+Udemy\\33.Writer\\bin\\Debug\\Escritor.txt";
        public Escritor()
        {
            InitializeComponent();
        }

        private void btnEscrever_Click(object sender, EventArgs e)
        {
            //grava meu texto
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(txbConteudo.Text);
            //limpa os buffers
            writer.Flush();
            //libera todos os recursos
            writer.Dispose();
            //fecha o arquivo
            writer.Close();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(path);
            //ler todo o arquivo
            txbConteudo.Text = reader.ReadToEnd();
            //ler apenas uma linha
            //txbConteudo.Text = reader.ReadLine();
            reader.Dispose();
            reader.Close();
        }

        private void btnLerBinario_Click(object sender, EventArgs e)
        {
            BinaryReader binreader = new BinaryReader(File.OpenRead(path));
            
            txbConteudo.Clear();

            while (binreader.BaseStream.Position != binreader.BaseStream.Length)
            {
                byte b = binreader.ReadByte();
                txbConteudo.Text += b + " ";

            }
            binreader.Close();
        }

        private void btnEscreverBin_Click(object sender, EventArgs e)
        {
            FileStream file = File.OpenWrite(path);
            BinaryWriter writer = new BinaryWriter(file);

            writer.Write(txbConteudo.Text.ToString());

            writer.Flush();
            writer.Dispose();
            writer.Close();
        }
    }
}
