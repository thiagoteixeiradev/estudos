using System.Threading.Tasks;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //Para criar uma nova thread, poderi fazer
        //Thread t = new Thread(Tarefa);
        //Porém o correto é
        Thread t = new Thread(new ThreadStart(Tarefa));
        //Define como secundário, quando a principal completar, a secundaria ira encerrar
        t.IsBackground = true;
        t.Start();
        //chama a secundária, e aguarda a finalização para proceder com a principal
        t.Join();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Tarefa Principal");

            //Uma Pausa de 1/2 segundo a cada laço
            Thread.Sleep(2000);
        }

    }

    static void Tarefa() {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Tarefa Secundária");
            //Uma Pausa de 1 segundo a cada laço
            Thread.Sleep(500);
        }

    }
}