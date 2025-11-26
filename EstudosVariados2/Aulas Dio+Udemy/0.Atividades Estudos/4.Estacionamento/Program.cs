using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de placas
            List<string> placas = new List<string>();
            List<DateTime> horaI = new List<DateTime>();
            List<DateTime> horaF = new List<DateTime>();


            //Vamos coletar e armazenar o valor da hora e da entrada
            double valorH = 0;
            double valorE = 0;
            Console.WriteLine("Seja muito bem vindo ao nosso sistema de estácionamento!");
            Console.WriteLine("Você precisa definir o valor de entrada de cada veiculo, por favor, digite o valor: ");
            valorE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Você precisa definir o valor da hora estacionada, por favor, digite o valor: ");
            valorH = Convert.ToDouble(Console.ReadLine());

        //Indo para o menu principal
        inicio:
            Console.WriteLine("Tudo ajustado, agora iremos ao menu principal");
            Console.WriteLine("Digite a opção desejada: \n1 - Cadastrar Veículo estacionado. \n2 - Remover um Veículo. \n3 - Lista os Veículos. \n4 - Encerrar.\n");
            int op = Convert.ToInt32(Console.ReadLine());


            //Direcionamento do menu
            switch (op)
            {
                case 1:
                    //Neste case damos entradas dos veiculos

                    //Captando placa
                    Console.WriteLine("Digite a placa do veiculo (XXX-NNN) para dar entrada: ");
                    placas.Add(Console.ReadLine());
                    goto inicio;
                case 2:
                    goto inicio;
                case 3:

                    //Neste case exibimos os veiculos.
                    Console.WriteLine("Os veiculos estacionados São: ");

                    foreach (string i in placas)
                    {
                        Console.WriteLine(i);

                    }
                    Console.ReadLine();
                    goto inicio;

                case 4:
                    break;
            }

            Console.WriteLine(valorE);
            Console.WriteLine(valorH);
            Console.WriteLine(op);
        }
    }
}
