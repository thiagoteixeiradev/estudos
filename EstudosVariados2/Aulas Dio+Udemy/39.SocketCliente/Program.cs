using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            

            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1324);

                socket.Connect(endPoint);

                Console.WriteLine("Conectado com exito, insira uma mensagem para enviar: ");
                string mensagem = Console.ReadLine();
                byte[] mensagemEnviar = Encoding.Default.GetBytes(mensagem);

                socket.Send(mensagemEnviar, 0, mensagemEnviar.Length, SocketFlags.None);


            }
            catch 
            {
                Console.WriteLine("Não foi posssível conectar ao servidor!");
            }
            
            socket.Close();
            Console.WriteLine("Pressione uma tecla para finalizar");
            Console.ReadLine();
        }
    }
}