using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ServidorDeArquivos
{
    public class FTServer
    {
        static IPEndPoint? ipEnd_Servidor;
        static Socket? sock_Servidor;
        public static string enderecoIP = "127.0.0.1";
        public static int portaHost = 1000;
        public static string pastaReceptora = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static ListBox ListaMensagem;

        public static void IniciarServidor()
        {
            try
            {
                ipEnd_Servidor = new IPEndPoint(IPAddress.Parse(enderecoIP), portaHost);
                sock_Servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sock_Servidor.Bind(ipEnd_Servidor);
                sock_Servidor.Listen(100);

                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Servidor em atendimento, aguardando para receber arquivos.");
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));

                while (true)
                {
                    Socket clienteSock = sock_Servidor.Accept();
                    clienteSock.ReceiveBufferSize = 16384;

                    try
                    {
                        // Buffer de recepção
                        byte[] dadosCliente = new byte[64 * 1024];
                        int totalRecebido = 0;

                        // === 1️⃣ Receber os 4 bytes do tamanho do nome ===
                        while (totalRecebido < 4)
                        {
                            int recebido = clienteSock.Receive(dadosCliente, totalRecebido, 4 - totalRecebido, SocketFlags.None);
                            if (recebido == 0) throw new Exception("Conexão fechada prematuramente.");
                            totalRecebido += recebido;
                        }

                        int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
                        if (tamanhoNomeArquivo <= 0 || tamanhoNomeArquivo > 100000)
                            throw new Exception($"Tamanho de nome inválido: {tamanhoNomeArquivo}");

                        // === 2️⃣ Receber o nome completo ===
                        while (totalRecebido < 4 + tamanhoNomeArquivo)
                        {
                            int recebido = clienteSock.Receive(
                                dadosCliente, totalRecebido,
                                (4 + tamanhoNomeArquivo) - totalRecebido,
                                SocketFlags.None);
                            if (recebido == 0) throw new Exception("Conexão fechada antes de receber o nome.");
                            totalRecebido += recebido;
                        }

                        string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);
                        string caminhoCompleto = Path.Combine(pastaReceptora, nomeArquivo);

                        using (BinaryWriter bWrite = new BinaryWriter(File.Open(caminhoCompleto, FileMode.Create)))
                        {
                            // === 3️⃣ Escrever dados já recebidos além do nome ===
                            if (totalRecebido > 4 + tamanhoNomeArquivo)
                            {
                                bWrite.Write(dadosCliente, 4 + tamanhoNomeArquivo, totalRecebido - (4 + tamanhoNomeArquivo));
                            }

                            // === 4️⃣ Continuar recebendo até o fim ===
                            while (true)
                            {
                                int recebido = clienteSock.Receive(dadosCliente, 0, dadosCliente.Length, SocketFlags.None);
                                if (recebido == 0) break;
                                bWrite.Write(dadosCliente, 0, recebido);
                            }
                        }

                        ListaMensagem.Invoke(new Action(() =>
                        {
                            ListaMensagem.Items.Add($"Arquivo recebido com sucesso: [{nomeArquivo}]");
                            ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                        }));
                    }
                    catch (Exception ex)
                    {
                        ListaMensagem.Invoke(new Action(() =>
                        {
                            ListaMensagem.Items.Add("Erro ao receber arquivo: " + ex.Message);
                            ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                        }));
                    }
                    finally
                    {
                        clienteSock.Shutdown(SocketShutdown.Both);
                        clienteSock.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro ao iniciar o servidor: " + ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
            }
            finally
            {
                sock_Servidor?.Close();
                sock_Servidor?.Dispose();
            }
        }
    }
}
