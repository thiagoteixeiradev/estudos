using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String para número
            int ex1 = Convert.ToInt32("5"); // Método para converter para INT
            Console.WriteLine("Conversão do numero que passei como string: " + ex1);
            ex1 = ex1 + 5; //Realizei uma operação com esta conversão
            Console.WriteLine("Realizei uma operação com esse inteiro: " + ex1);
            int ex2 = int.Parse("12"); //Usando Parse para conversão
            Console.WriteLine("Agora estou convertendo usando o Parse: " + ex2);
            ex2 = ex2 + 5;
            Console.WriteLine("Agora realizei outra operação: " + ex2);
            //Convert é mais genérico podendo lidar com vários tipos, retorna um valor padrão caso a conversão falhe.
            //Já o Parse é mais específico, um exemplo é tentar converter algo vazio.
            int ex3 = Convert.ToInt32(null);
            Console.WriteLine("Converti algo vazio com convert: " + ex3);
            //Esta mesma operação com Parse irá gerar uma exceção.
            #endregion

            #region Número para string
            int ex4 = 5;
            string tex1 = ex4.ToString();
            //Convert.ToString(ex4); Outro método
            Console.WriteLine("Converti um número para uma string: " + tex1);

            #endregion

            #region Cast implícito
            int a = 5;
            double b = a;
            Console.WriteLine("Como já visto anteriormente, o casting pode ser realizado em algumas ocasiões: " + b);
            // O grupo dos inteiros está contigo dentro do double, então não preciso me preucupar com a conversão.
            // Outro exemplo é int para long ( O range do int está em 2 bilhões, já o long são 2 trilhões.

            #endregion

            #region Convertendo de maneira segura
            Console.WriteLine("Vamos explorar alguns erros");
            string exa = "15-";
            int exb = 0;
            int.TryParse(exa, out exb); //Ele irá tentar converter exa, caso contrário a saída será exb.
            Console.WriteLine(exb);
            #endregion
        }
    }
}
