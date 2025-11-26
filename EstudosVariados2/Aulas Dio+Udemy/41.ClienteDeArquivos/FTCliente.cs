using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41.ClienteDeArquivos
{
    internal class FTCliente
    {
        static IPEndPoint ipEnd_Cliente;
        static Socket clientSocket_Cliente;
        public static string enderecoIP = "127.0.0.1";
        public static int portaHost = 1000;
        public static Label LabelMensagem;

        public static void EnviarArquivo(string arquivo)
        {
            try
            {
                ipEnd_Cliente = new IPEndPoint(IPAddress.Parse(enderecoIP), portaHost);
                clientSocket_Cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";
                pasta += arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1);

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo);

                if (nomeArquivoByte.Length > 50000 * 1024)
                {
                    LabelMensagem.Invoke(new Action(() =>
                    {
                        LabelMensagem.ForeColor = Color.Red;
                        LabelMensagem.Text = "O tamanho do arquivo é maior que 50Mb, envie um arquivo menor";

                    }));
                    return;
                }
                string caminhoCompleto = pasta + arquivo;
                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clienteData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLen.CopyTo(clienteData, 0);
                nomeArquivoByte.CopyTo(clienteData, 4);
                fileData.CopyTo(clienteData, 4 + nomeArquivoByte.Length);
                clientSocket_Cliente.Connect(ipEnd_Cliente);
                clientSocket_Cliente.Send(clienteData, 0, clienteData.Length, 0);
                clientSocket_Cliente.Close();
                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = "Arquivo ["+ arquivo +"] Transferido!";

                }));

            }
            catch (Exception ex)
            {
                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = "Ocorreu um erro!" + ex.Message;

                }));
            }
            finally
            {
                clientSocket_Cliente.Close();
            }
        }


    }
}
