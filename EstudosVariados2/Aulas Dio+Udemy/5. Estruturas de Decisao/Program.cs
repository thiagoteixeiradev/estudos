using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Operador If Else
            /*
            //Definimos a variavel de estoque
            int qEstoque = 10;
            Console.WriteLine("Nós possuimos " + qEstoque + " em estoque, quantas deseja comprar?");

            //Agora vamos receber do usuário quantas unidades ele deseja comprar
            int qCompra = Convert.ToInt32(Console.ReadLine());

            //usando um booleano para validar a venda
            bool valida = qEstoque >= qCompra && qCompra > 0;
            //Meu estoque precisa ser maior que o valor da compra, e o valor da compra precisa ser maior que 0
            //Não existe uma venda com 0 itens

            //Agora vem a nossa estrutura de decisão
            if (valida) 
            //Poderia usar um booleano para satisfazer ou não essa condição, ou a operação qEstoque >= qCompra
            {
                Console.WriteLine("Venda realizada com sucesso.");
            }
            //Caso o if não seja atendido
            else if (valida == false)
            //else if é um dos meios de se aninhar um if, podemos usar quantos else if quisermos, um atrás do outro
            {
                Console.WriteLine("Valor para compra precisa ser maior do que 0");
            }
            else
            {
                Console.WriteLine("Não temos a quantidade desejada em estoque.");
            }
            //Posso usar booleanos também para conferir se a condição foi ou não atendida
            Console.WriteLine($"É possível realizar a venda? "+ valida);
            */
            #endregion

            #region Aninhando If else
            /*
            int n1 = 9;
            if (n1 > 5)
            {
                Console.WriteLine("O número é maior que 5");

                if (n1 % 2 == 0) 
                { 
                    Console.WriteLine("O número é PAR");
                }
                else
                {
                    Console.WriteLine("O número é impar");
                }
            }
            */
            #endregion

            #region switch Case
            /*
            //Verificar se o usuário digitou uma vogal
            Console.WriteLine("Digite uma letra");
            string letra = Console.ReadLine();

            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
            //Além da string, poderia usar um número, como case 1, case 3 case 4 para fazer um menu de 1 a 4 por exemplo.
                    Console.WriteLine("O usuário digitou uma vogal");
                    break;

                default:
                    Console.WriteLine("Oque o usuário digitou, não é uma vogal");
                    break;
            }
            */
            #endregion

            #region Go to
            /*
        Inicio: //Os ":" transformou a palavra em um label
            Console.WriteLine("Escolha uma opção");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                default:
                    goto Inicio; //irá para label início.

                case 1:
                    valor += 100;
                    break;

                case 2:
                    valor += 50;
                    goto case 1;
                //No caso 2, ele irá executar o caso e retornar ao caso 1.
                //não coloquei um break no case 2, pois ele já vai pegar o break do caso 1
            }
            Console.WriteLine("Valor final: " + valor);
            */
            #endregion

            #region While
            /*
            int controle = 0;
            //Nosso contador
            Console.WriteLine("Vamos contar?");

            while ( controle <= 10) //Enquanto o contador for menor ou igual a condição, estaremos contando.
            {
                Console.WriteLine($"Estamos contando...{controle}!");
                controle++;
                Console.ReadLine();
            }
            */
            #endregion

            #region Do...while
            /*
            int controle = 0;
            Console.WriteLine("Vamos contar? Mas dessa vez com do...while");
            //Dessa vez vamos executar a ação, e depois nos preucupamos em validar a repetição
            do
            {
                Console.WriteLine($"Estamos contando...{controle}!");
                controle++; 
                Console.ReadLine( );

            } while (controle <= 10);
            */
            #endregion

            #region For
            /*
            Console.WriteLine("Agora estamos contando com o FOR");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Contando {i}...");
                Console.ReadKey();
                
            }
            */
            #endregion

            #region Foreach
            int i = 0;
            string[] nomes = { "Romario", "Gabriel", "Dani" };
            foreach (string item in nomes)
            {
                Console.Write(" Nome: " + nomes[i]);
                i++;
            }
            Console.ReadKey();
            #endregion

            #region Operador Ternário
            /*
            int n2 = 4;
            string mensagem = "";
            
            if (n2 > 5)
            {
                mensagem = " maior do que 5";
            }
            else
            {
                mensagem = " menor do que 5";
            }
            
            //Para realizar esta mesma operação acima com um operador ternário, podemos fazer:
            mensagem = n2 > 5 ? "Maior que 5" : "Menor que 5";
            //O operador : é o chamado operador ternário, já o ? está condicionando a condição ao operador

            Console.WriteLine($"O número é {mensagem}");
            
            */
            #endregion

        }
    }
}
