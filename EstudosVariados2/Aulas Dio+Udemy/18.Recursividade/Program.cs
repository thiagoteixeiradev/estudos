using System;

namespace Recursividade
{
    class Recursiva
    {
        public static void Executar(string mensagem, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }
        }

        public static void ExecutarRecursivo(string mensagem, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursivo(mensagem, n - 1); // diminui 1 a cada chamada
            }
        }
        public static int Fatorial(int num)
        {
            if ( num == 0)
            {
                return 1;
            }
            return num * Fatorial(num - 1);
        }

        public static void Main(string[] args)
        {
            ExecutarRecursivo("Olá mundo (recursivo)", 5);
            //Estudo das propriedades do main
            /*
            string nome = args[0];
            string senha = "123";
            if (senha != args[1])
            {
                Console.WriteLine("Acesso negado");
            }
            else
            {
                Console.WriteLine("Acesso concedido");
                Console.WriteLine("Estamos testando o args do método main :" + nome);
            }
            */
            Console.WriteLine("Vamos usar recursividade para fatorar: ");
            Console.WriteLine("Informe um número para verificar seu fatorial: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fatorial de {num} é: {Fatorial(num)}");
                

            Console.ReadKey();
        }
    }
}
