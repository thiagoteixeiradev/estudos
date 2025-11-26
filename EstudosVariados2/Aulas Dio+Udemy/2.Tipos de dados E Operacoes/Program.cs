using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresMat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de dados
            Console.WriteLine("\n=====Primeiro iremos verificar os tipos de dados=====");
            string s1 = "Romario";
            Console.WriteLine("Esta variável é uma string, e armazena caractéres: " + s1);
            char c1 = 'R';
            Console.WriteLine("Porém o char armazena apenas um caráctere: " + c1);
            bool exb1 = false;
            Console.WriteLine("Booleanos podem ser verdadeiros ou falsos, no momento, este exemplo é: " + exb1);
            exb1 = true;
            Console.WriteLine("Porém agora ele é: " + exb1);
            int exint1 = 31;
            Console.WriteLine("Inteiros (int) são números inteiros: " + exint1);
            Console.WriteLine("Ainda temos outros tipos de dados para números: float, long, uint, short e ulong.\nA diferença entre eles é o alcançe dos números, porém o uint representa apenas números positivos");
            double deex = 10.5;
            Console.WriteLine("Podemos usar os tipos decimal, double e float para números fracionados, como por exemplo: " + deex);
            #endregion

            #region Trabalhando com datas
            Console.WriteLine("\n=====Iremos trabalhar com datas agora=====");
            //pegar data atual
            DateTime dataAtual = DateTime.Now; //.Now se refere ao horário do computador atual.
            Console.WriteLine("A data atual é: " + dataAtual);
            dataAtual = DateTime.Now.AddDays(5); //Estou captando a data atual + 5 dias.
            Console.WriteLine("Daqui a cinco dias será: " + dataAtual);
            dataAtual = DateTime.Now;
            Console.WriteLine("A data atual formatada é: " + dataAtual.ToString("dd/MM/yyyy"));
            Console.WriteLine("A hora atual formatada é: " + dataAtual.ToString("HH:mm"));


            #endregion

            #region Operações
            Console.WriteLine("\n=====Vamos fazer operações simples=====");
            //Primeiro meio de fazer uma operação.
            //int x = 10 + 12;

            //Outro meio
            int x, y, z;
            y = 10;
            z = 12;
            x = z + y;
            // Também é possível fazer dentro do writeline
            //Console.WriteLine("A soma de 10 + 12 é:" z + y);

            Console.WriteLine("A soma de 10 + 12 é: " + x);
            x = z - y;
            Console.WriteLine("A subtração de 12 - 10 é: " + x);
            x = z * y;
            Console.WriteLine("A Multiplicação de 12 * 10 é: " + x);
            x = z / y;
            Console.WriteLine("A divisão de 12 / 10 é: " + x);
            x = z % y;
            Console.WriteLine("O resto da divisão de 12 / 10 é: " + x);
            #endregion

            #region Operadores de atribuição
            // Operadores de Atribuição
            Console.WriteLine("\n=====Agora iremos ver Operadores de atribuição=====");
            x = 10;
            x += 2; //irá executar x = x + 2
            Console.WriteLine("X = 10, X + 2 =: " + x);
            x -= 2;
            Console.WriteLine("X agora é 12, então X - 2 =: " + x);
            x *= 2;
            Console.WriteLine("Como x agora é 10, X * 2 é: " + x);
            x /= 2;
            Console.WriteLine("Como x agora é 20, X / 2 é: " + x);
            x = 21;
            x %= 2;
            Console.WriteLine("Como x sendo 21, o resto da divisão de X / 2 é: " + x);
            #endregion

            #region Critérios em operações
            //Precedência de operadores
            // A ordem de critério é (), /* e por fim +-
            //Exemplo:
            Console.WriteLine("\n=====Agora iremos ver a ordem de critérios=====");
            x = 5 + 5 * 2;
            Console.WriteLine("5 + 5 * 2 = " + x);
            x = (5 + 5) * 2;
            Console.WriteLine("(5 + 5) * 2 = " + x);
            z = 2;
            y = 10;
            x = (y * z) + (y / z);
            Console.WriteLine("(10 * 2) + (10 / 2) = " + x);
            #endregion

            #region Incremento e decremento
            //Incremento e decremento
            Console.WriteLine("\n=====Agora iremos ver Operadores de atribuição=====");
            x = 0;
            x++;
            Console.WriteLine("Com x sendo 0, seu incremento é: " + x);
            x--;
            Console.WriteLine("Como x agora é 1, seu decremento é: " + x);

            // Também poderia fazer x = x + 1, ou x = x - 1; ou ainda ++x ou --x;
            #endregion

            #region Concatenação
            //Concatenação
            //Ao fazermos uma operação de adição com string, é feito uma concatenação
            Console.WriteLine("\n=====Agora iremos ver Concatenação=====");
            string nome = "Romario " + "Braz";
            string nomeCompleto = nome + " da Rocha";
            Console.WriteLine("Meu nome é: " + nome);
            Console.WriteLine("Já meu nome completo é: " + nomeCompleto);
            #endregion

            #region Booleanos, igualdade, diferença, e comparação de strings.
            //Operadores de igualdade e booleanos
            Console.WriteLine("\n=====Agora iremos ver booleanos=====");
            bool res;
            res = 100 == 50;
            Console.WriteLine("100 é igual a 50?:" + res);
            res = 100 == (50 * 2);
            Console.WriteLine("100 é igual a 50 * 2 ?:" + res);

            //Operador de diferente
            res = (100 != 100);
            Console.WriteLine("100 é diferente de 100?:" + res);
            res = (100 != 50);
            Console.WriteLine("100 é diferente de 100?:" + res);

            //Comparando strings
            nome = "Romario";
            res = nome == "Amanda";
            Console.WriteLine("Meu nome é Amanda?:" + res);
            res = nome == "Romario";
            Console.WriteLine("Meu nome é Amanda?:" + res);
            #endregion

            #region Operadores relacionais
            //Operadores relacionais
            Console.WriteLine("\n=====Agora iremos ver Operadores relacionais=====");
            x = 0;
            y = 0;
            z = 0;
            //estou apenas zerando minhas variáveis usadas anteriormente
            x = 50;
            y = 100;
            res = x > y;
            Console.WriteLine("50 é maior que 100? " + res);
            res = x < y;
            Console.WriteLine("100 é maior que 50? " + res);
            z = 50;
            res = y == x + z;
            Console.WriteLine("50 + 50 é igual a 100? " + res);
            z = 50;
            y++;
            res = y >= x + z;
            Console.WriteLine("101 é maior ou igual a 100? " + res);
            z = 50;
            y++;
            res = y <= x + z + 10;
            Console.WriteLine("101 é menor ou igual a 110? " + res);
            #endregion

            #region Operadores Lógicos
            //Operadores lógicos AND e OR
            Console.WriteLine("\n=====Agora iremos ver Operadores lógicos=====");
            bool res1 = 100 == 100;
            bool res2 = 50 == 50;
            res = res1 && res2;

            Console.WriteLine("Minha operação lógica é verdadeira? " + res);
            res2 = 50 == 51;
            res = res1 && res2;
            Console.WriteLine("E agora, minha operação continua verdadeira? " + res);
            res = res1 || res2;
            Console.WriteLine("Uma ou outra operação ainda é verdadeira? " + res);
            #endregion

            Console.ReadKey();

        }
    }
}
