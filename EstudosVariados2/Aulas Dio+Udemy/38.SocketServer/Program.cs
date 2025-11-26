using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1324);

            socket.Bind(endPoint);

            socket.Listen(5);

            Console.WriteLine("Escutando...");

            Socket escutar = socket.Accept();

            byte[] bytes = new byte[255];

            int tamanho = escutar.Receive(bytes, 0, bytes.Length, SocketFlags.None);

            Array.Resize(ref bytes, tamanho);

            Console.WriteLine("Mensagem Recebida:");

            Console.WriteLine(Encoding.Default.GetString(bytes));

            escutar.Close();

            Console.WriteLine("Servidor Finalizado, Pressione qualquer tecla para encerrar.");

            Console.ReadKey();
        }
    }
}