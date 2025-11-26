using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivos
{
    public partial class Form1 : Form
    {
        string pasta = @"D:\Arquivos\GitHub\Estudos.net\Aulas Dio+Udemy\32.Arquivos\bin\Debug\Arquivos\\";
        string arquivo = "Teste.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Ver se o arquivo existe
            string pasta = @"D:\Arquivos\GitHub\Estudos.net\Aulas Dio+Udemy\32.Arquivos\bin\Debug\Arquivos\\";
            string arquivo = "Teste.txt";
            bool res = File.Exists(pasta + arquivo);

            lbResultado.Text = res.ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            File.Delete(pasta + arquivo);
            MessageBox.Show("Deletado com sucesso.");
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (!File.Exists(pasta + arquivo))
            {
                File.Create(pasta + arquivo).Close();
                //Ao criar um arquivo, ele abre o arquivo para criação, então precisamos fechar ele.
                File.WriteAllText(pasta + arquivo,"Este é um texto para teste.", Encoding.Default);
                MessageBox.Show("Arquivo Criado!");
            }
            else { MessageBox.Show("Arquivo já existe!"); }
        }

        private void q_Click(object sender, EventArgs e)
        {
            if (File.Exists(pasta + arquivo))
            {
                File.Copy(pasta + arquivo, pasta + "Copia_" + arquivo, true);
            }
            else { MessageBox.Show("Arquivo já existe!"); }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if (File.Exists(pasta + arquivo))
            {
                File.Move(pasta + arquivo, pasta + "Movido.txt");
            }
            else { MessageBox.Show("Arquivo Não encontrado!"); }
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            if (File.Exists(pasta + arquivo))
            {
                lbResultado.Text = File.ReadAllText(pasta + arquivo, Encoding.Default);

            }
            else { MessageBox.Show("Arquivo Não encontrado!"); }
        }

        private void btnFileInfo_Click(object sender, EventArgs e)
        {

            if (File.Exists(pasta + arquivo))
            {
                FileInfo info = new FileInfo(pasta + arquivo);
                lista.Items.Clear();
                lista.Items.Add(info.FullName);
                lista.Items.Add(info.Name);
                lista.Items.Add(info.Length);
                lista.Items.Add(info.Extension);
                lista.Items.Add(info.Directory);
                lista.Items.Add(info.DirectoryName);
                lista.Items.Add(info.Attributes);
                lista.Items.Add(info.CreationTime);
            }
            else { MessageBox.Show("Arquivo Não encontrado!"); }


        }

        private void btnDirInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoArquivo = Path.Combine(pasta, arquivo);
                string backup = Path.Combine(pasta, "Backup");
                string[] dirs = Directory.GetDirectories(pasta);
                string[] hds = Directory.GetLogicalDrives();

                if (File.Exists(caminhoArquivo))
                {
                    lista.Items.Clear();

                    // Verifica se o diretório existe
                    lista.Items.Add("Diretório existe: " + Directory.Exists(pasta));

                    // Lista os arquivos na pasta
                    foreach (string file in Directory.GetFiles(pasta))
                    {
                        lista.Items.Add("Arquivo: " + Path.GetFileName(file));
                    }

                    // Lista os diretórios
                    foreach (string dir in dirs)
                    {
                        lista.Items.Add("Pasta: " + Path.GetFileName(dir));
                    }

                    // Lista as unidades lógicas
                    foreach (string h in hds)
                    {
                        lista.Items.Add("Unidade: " + h);
                    }

                    // Cria o diretório Backup, se não existir
                    if (!Directory.Exists(backup))
                    {
                        Directory.CreateDirectory(backup);
                        MessageBox.Show("Diretório 'Backup' criado!");
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado em: " + caminhoArquivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDirDel_Click(object sender, EventArgs e)
        {
            Directory.Delete(pasta + "/Backup");
        }

        private void btnDireMov_Click(object sender, EventArgs e)
        {
            string origem = Path.Combine(pasta, "Backup");
            string destino = Path.Combine(pasta, "Backup2");

            try
            {
                if (!Directory.Exists(origem))
                {
                    MessageBox.Show("A pasta de origem não existe!");
                    return;
                }

                if (Directory.Exists(destino))
                {
                    MessageBox.Show("A pasta de destino já existe!");
                    return;
                }

                Directory.Move(origem, destino);
                MessageBox.Show("Pasta movida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao mover: " + ex.Message);
            }
        }

        private void btnDirInfo_Click_1(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(pasta);
            lista.Items.Clear();
            lista.Items.Add(info.FullName);
            lista.Items.Add(info.Parent);
            lista.Items.Add(info.Name);
            lista.Items.Add(info.CreationTime);
            lista.Items.Add(info.Exists);
            lista.Items.Add(info.Root);
        }
    }

}
