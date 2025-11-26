using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42.Servidor_de_Chat
{
    //especifica os paramestros que estamos passando com o evento
    public delegate void StatusChangedEventHandler(object sender, StatusChangeEvent e);
    

    internal class Servidor
    {
        //Armazena os usuários e conexções (acessando/consultando por usuário)
        public static Hashtable htUsuarios = new Hashtable(30); //limite setado
        public static Hashtable htConexoes = new Hashtable(30);
        //Armazenar IP e a porta
        private IPAddress enderecoIP;
        private int portaHost;
        private TcpClient tcpClient;

        //evento e argumento para notificar o formulário ao usuário interagir (login/out)
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventHandler e;

        public Servidor(IPAddress endereco, int porta)
        {
            enderecoIP = endereco;
            portaHost = porta;
        }

        //Thread para escutar as conexões
        private TcpListener tlsCliente;
        //Objeto quue irá escutar as conexões
        private Thread tlsListener;

        //status do servidor para manter as conexões ativas
        bool StatusServidor = false;

        public static void IncluirUsuario(TcpClient tcpUsuario, string strUsername)
        {
            Servidor.htUsuarios.Add(strUsername, tcpUsuario);
            Servidor.htConexoes.Add(tcpUsuario, strUsername);

            //Informa aos usuários sobre a nova conexão
            EnviaMensagemAdmin(htConexoes[tcpUsuario] + " entrou!");
        }

        public static void RemoverUsuario(TcpClient tcpUsuario)
        {
            //se o usuário existir
            if (htConexoes[tcpUsuario] != null)
            {
                EnviaMensagemAdmin(htConexoes[tcpUsuario] + "Saiu...");

                //Remover da Hashtable
                Servidor.htUsuarios.Remove((string)Servidor.htConexoes[tcpUsuario]);
                Servidor.htConexoes.Remove(tcpUsuario);
            }
        }

        //Evento para disparar a mudança de status
        public static void OnStatusChanged(StatusChangeEvent e)
        {
            StatusChangedEventHandler StatusChangeEvent = StatusChanged;

            if (StatusChangeEvent != null)
            {
                //invocar o delegate
                StatusChangeEvent(null, e);
            }
        }


        //Envia Mensagens Administrativas
        public static void EnviaMensagemAdmin(string mensagem)
        {
            StreamWriter swSender;
            OnStatusChanged(new StatusChangeEvent("Administrador: " + mensagem));

            //array de clientes tcps igual ao numero de clientes existentes
            TcpClient[] tcpClients = new TcpClient[Servidor.htUsuarios.Count];
            //copia to TcpCliente para o array
            Servidor.htUsuarios.Values.CopyTo(tcpClients, 0);
            //Percorre a lista de clientes TCP
            for (int i = 0; i < tcpClients.Length; i++)
            {
                try
                {
                    //Tratar mensagem em branco e conexões nulas
                    if (mensagem.Trim().Length > 0 || tcpClients[i] == null)
                    {
                        continue;
                    }

                    //Envia a mensagem para o usuário atual no laço
                    swSender = new StreamWriter(tcpClients[i].GetStream());
                    swSender.WriteLine("ADministrador: " + mensagem);
                    swSender.Flush();
                    swSender = null;
                }
                catch 
                {
                    //Para problemas que ocorrerem
                    RemoverUsuario(tcpClients[i]);
                }
                
            }
        }

        //Envia mensagens de um usuário para todos
        public static void EnviaMensagem(string Origem, string Mensagem)
        {
            StreamWriter swSender;
            //Exibi a mensagem na aplicação
            OnStatusChanged(new StatusChangeEvent(Origem + " disse: " + Mensagem));

            //Cria um array de clientes TCPs igual ao número de clientes existentes
            TcpClient[] tcpClients = new TcpClient[Servidor.htUsuarios.Count];

            //copia to TcpCliente para o array
            Servidor.htUsuarios.Values.CopyTo(tcpClients, 0);

            //Percorre o array com todos os clientes
            for (int i = 0; i < tcpClients.Length; i++)
            {
                try
                {
                    //Tratar mensagem em branco e conexões nulas
                    if (Mensagem.Trim().Length > 0 || tcpClients[i] == null)
                    {
                        continue;
                    }

                    //Envia a mensagem para o usuário atual no laço
                    swSender = new StreamWriter(tcpClients[i].GetStream());
                    swSender.WriteLine(Origem + " disse: " + Mensagem);
                    StreamWriter sw = new StreamWriter(tcpClients[i].GetStream());
                    sw.WriteLine(Origem + " disse: " + Mensagem);
                    swSender.Flush();
                    swSender = null;
                    sw.Flush();

                    
                }
                catch
                {
                    //Para problemas que ocorrerem
                    RemoverUsuario(tcpClients[i]);
                }

            }


        }

        public void IniciaAtendimento()
        {
            try
            {
                //pega o ip
                IPAddress ipLocal = enderecoIP;
                int portaLocal = portaHost;

                //Cria um objeto tcp para ouvir usando o ip do servidor e porta definida
                tlsCliente = new TcpListener(ipLocal, portaLocal);
                tlsCliente.Start();

                //Iniciar a thread para ouvir as conexões
                StatusServidor = true;
                tlsListener = new Thread(MantemAtendimento);
                tlsListener.IsBackground = true;
                tlsListener.Start();
            }
            catch (Exception ex)
            {

            }
        }
        private void MantemAtendimento() 
        {
            //Enquanto o server estiver ligado
            while (StatusServidor)
            {
                //Aceita a conexão pendente
                tcpClient = tlsCliente.AcceptTcpClient();
                //Cria a nova instância
                Conexao newConexao = new Conexao(tcpClient);
            }
        }
    }
}
