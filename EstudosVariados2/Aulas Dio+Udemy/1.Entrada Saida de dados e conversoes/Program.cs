using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_e_Saida_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Entrada e saída de dados
            Console.WriteLine("Isto é uma Saída de dados.");
            Console.WriteLine("Agora você irá dar entrada de dados.");
            Console.WriteLine("Digite qualquer coisa e aperte ENTER:");
            string cod = Console.ReadLine();
            Console.WriteLine("Você digitou: "+cod);
            //Console.ReadKey(); Console.Read();
            Console.WriteLine("Agora digite seu nome e aperte ENTER:");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: "+nome);
            Console.WriteLine("Agora iremos converter os tipos de dados");
            #endregion

            #region Conversão implicita
            //Exemplo de conversão implicita
            byte num1 = 100; // 8 bits de 0 a 255
            ushort num2; // 16 bits de 0 a 65.535
            num2 = num1; //Posso armazenar o byte dentro do short, pois todos seus valores possiveis do byte comportam no ushort.
                         // byte > ushort > float > double...
            #endregion

            #region Conversão explicita
            //Conversão explicita
            ushort nume1 = 500;
            byte nume2 = (byte)nume1;
            //Pode ocorrer perca de dados neste tipo de conversão, pois o ushort é maior que byte.
            Console.WriteLine(nume2);
            //Foi escrito 244, porém o valor era 500, ocorreu uma perda de dados.
            float numf1 = 2500.786f;
            int numf2 = (int)numf1;
            Console.WriteLine(numf2);
            //Int não comporta números decimais.
            char letra = (char)97;
            Console.WriteLine(letra);
            //Foi imprimido a, pois 97 é seu código asc.
            #endregion

            #region Parse
            string txtnumero = "1985";
            int numerop1 = int.Parse(txtnumero);
            Console.WriteLine("O número convertido pelo Parse é: " +numerop1);
            string numerob1 = "50.786";
            float nflot1 = float.Parse(numerob1);
            Console.WriteLine("O número convertido pelo Parse é: " + nflot1);
            #endregion

            #region Convert
            string textoconvert1 = Convert.ToString(2500);
            double textoconvert2 = Convert.ToDouble(false);
            Console.WriteLine(textoconvert1);
            Console.WriteLine(textoconvert2); //O 0 Exibido é referente ao valor de false.
            //Nem sempre é possível converter
            int textoconvert3 = Convert.ToInt32('c');
            Console.WriteLine(textoconvert3);
            //O valor que foi exibido, na verdade é seu código, e não o char.

            #endregion

        }
    }
}
