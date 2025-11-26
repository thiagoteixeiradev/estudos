using System.Threading.Tasks;

namespace TaskApp
{
    public class Programa
    {
        static void Main(string[] args)
        {
            #region Task1
            /*
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            //Task t2 = Task.Run(Tarefa);
            //Mais simples:
            //Task.Run(Tarefa);

            //Ou
            Task.Factory.StartNew(Tarefa);

            //ou

            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Tatefa {i} Anonima");
                }
            });
            


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Tatefa {i} Solta");
            }

            Console.ReadLine();
            */
            #endregion

            #region Taks em array 

            /*
            //Criei um array de tasks
            Task[] tasks =
            {
                //Defini e startei as tasks na criação
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #1");
                }),

                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #2");
                }),

                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #3");
                }),
            };

            
            //Maneiras de chamar o principal após as tasks
            //Console.ReadKey();

            //Console.WriteLine("Principal");
            //Pois "demora" a entrada do readkey
            

            //Outra maneira de alterar a ordem

            Task.WaitAll(tasks);
            Console.WriteLine("Principal");

            //Para um wait sem array, eu posso usar Task.WaitAll(t1, t2, t3);
            */
            #endregion

            #region Retorno das Tasks

            //Criando task com retorno

            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(5));

            //Usando seu retorno
            //Console.WriteLine(tarefa1.Result);

            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(11);
            });

            //ContinueWith informa que a tarefa2 devera esperar a tarefa1

            Task<int> tarefa2 = tarefa1.ContinueWith((num) => 
            {
                return num.Result * 2;
            });

            Task<string> tarefa3 = tarefa2.ContinueWith((num2) =>
            {
                return "Valor Final: " + num2.Result;
            });

            Console.WriteLine(tarefa3.Result);

            Console.ReadKey();

            #endregion
        }

        static int Dobro(int num)
        {
            return num * 2;
        }

        static void Tarefa()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Tatefa {i}");
                }
            }
            
        
    }
}