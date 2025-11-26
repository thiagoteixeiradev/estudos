using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _42.Servidor_de_Chat
{
    //Iremos tratar as conexoes e instâncias dos clientes conectados
    internal class Conexao
    {
        TcpClient tcpClient;
        private Thread thrSender;
        private StreamReader srReceptor;
        private StreamWriter srEnviador;
        private string usuarioAtual;
        private string resposta;

        public Conexao(TcpClient tcpCon)
        {
            tcpClient = tcpCon;
            //Aceita e aguarda a mensagem
            thrSender = new Thread(AceitaConCliente);
            thrSender.IsBackground = true;
            thrSender.Start();

        }

        private void AceitaConCliente()
        {
            srReceptor = new StreamReader(tcpClient.GetStream());
            srEnviador = new StreamWriter(tcpClient.GetStream());

            //Ler informações do client
            usuarioAtual = srReceptor.ReadLine();
            //resposta
            if (usuarioAtual != "")
            {
                if (Servidor.htUsuarios.Contains(usuarioAtual))
                {
                    //na mensagem 0 = > usuario nao conectado
                    srEnviador.WriteLine("0|Este usuário já existe");
                    srEnviador.Flush();
                    FechaConexao();
                    return;
                } else if (usuarioAtual == "Administrador")
                {

                    srEnviador.WriteLine("0|Usuário não permitido");
                    srEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else
                {
                    //conectou com sucesso
                    srEnviador.WriteLine("1");
                    srEnviador.Flush();
                    //incluir na hash table
                    Servidor.IncluirUsuario(tcpClient, usuarioAtual);
                }
            }
            else
            {
                FechaConexao();
                return;
            }

            try
            {
                //aguardar mensagem do usuário
                while ((resposta = srReceptor.ReadLine()) != "")
                {
                    //remover se invalido
                    if(resposta == null)
                    {
                        Servidor.RemoverUsuario(tcpClient);
                    }
                    else
                    {
                        Servidor.EnviaMensagem(usuarioAtual, resposta);
                    }
                }
            }
            catch
            {
                Servidor.RemoverUsuario(tcpClient);
            }

        }

        private void FechaConexao()
        {
            tcpClient.Close();
            srReceptor.Close();
            srEnviador.Close();
        }
    }
}
