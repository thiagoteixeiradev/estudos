using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicandoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O objetivo é multiplicar uma matrix 3 x 2 e uma 2 x 3 para gerar uma  2 x 2 
            int[,] m1 = new int[2, 3];
            int[,] m2 = new int[3, 2];
            int[,] r = new int[2, 2];

            //Agora vamos fazer o usuário preencher a matriz
            Console.WriteLine("Preencha a nossa primeira matriz: ");

            for (int linha = 0; linha < 2; linha++) 
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    //Preencho a minha primeira matriz
                    Console.Write("#1. Posição ["+ linha +"][" + coluna +"]: ");
                    m1[linha, coluna] = int.Parse(Console.ReadLine());

                }

            }
            //Agora vamos para a segunda matriz
            Console.WriteLine("\nPreencha a nossa segunda matriz: ");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    //Preencho a minha primeira matriz
                    Console.Write("#1. Posição [" + linha + "][" + coluna + "]: ");
                    m2[linha, coluna] = int.Parse(Console.ReadLine());

                }

            }
            //Agora vamos começar os resultados
            Console.WriteLine("Agora que já coletamos os dados, vamos calcular as matrizes");
            r[0, 0] = (m1[0,0] *  m2[0, 0]) + (m1[0, 1] * m2[1, 0]) + (m1[0, 2] * m2[2, 0]);
            r[1, 0] = (m1[1, 0] * m2[0, 0]) + (m1[1, 1] * m2[1, 0]) + (m1[1, 2] * m2[2, 0]);
            r[0, 1] = (m1[0, 0] * m2[0, 1]) + (m1[0, 1] * m2[1, 1]) + (m1[0, 2] * m2[2, 1]);
            r[1, 1] = (m1[1, 0] * m2[0, 1]) + (m1[1, 1] * m2[1, 1]) + (m1[1, 2] * m2[2, 1]);

            Console.WriteLine("["+ r[0,0] +"][" + r[0,1]+"]");
            Console.WriteLine("[" + r[1, 0] + "][" + r[1, 1] + "]");
            Console.ReadKey();

        }
    }
}
