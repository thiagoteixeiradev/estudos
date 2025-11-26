using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fila
            /*
            Queue<int> fila = new Queue<int>(); // Cria uma fila de inteiros
            //Fila tem modo FIFO - First in first out
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(8);

            foreach (int i in fila)
            {

                Console.WriteLine(i);

            }
            Console.WriteLine($"Removendo elemento: {fila.Dequeue()}");
            Console.WriteLine("Nova fila: ");
            foreach (int i in fila)
            {

                Console.WriteLine(i);

            }
            //FIFO = Primeiro a entrar, primeiro a sair
            */
            #endregion

            #region Pilha
            /*
            Stack<int> pilha = new Stack<int>();
            //Pilhas são LIFO = Last In First Out, na escrita, teremos a ordem inversa.

            //inserindo objetos no topo
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(4);
            pilha.Push(8);
            pilha.Push(16);

            foreach (int i in pilha)
            {
                Console.WriteLine(i);
            }
            //removendo um elemento
            Console.WriteLine($"Agora iremos remover o elemento: {pilha.Pop()}");
            //No caso o elemento removido foi o 16, o ultimo a ter sido adicionado

            foreach (int i in pilha)
            {
                Console.WriteLine(i);
            }
            */
            #endregion

            #region Dicionário
            //declaramos o dicionario sendo que <chave, tipo de dado>
            //Todos elementos são únicos
            Dictionary<int, string> estados = new Dictionary<int, string>();

            estados.Add(1, "Paraíba");
            estados.Add(2, "Bahia");
            estados.Add(3, "Pernambuco");
            estados.Add(4, "São Paulo");
            estados.Add(5, "Amazonasnas");
            //Caso eu tente adicionar outro item com a mesma chave, irá gerar uma exceção.
            //Note que a key é como uma primary key, ela é única.

            foreach (var i in estados)
            {
                Console.WriteLine($"Chave{i.Key}, Estado: {i.Value}");
            }

            Console.WriteLine("Agora vamos manipular os elementos");

            //para remover, posso apenas passar o valor da chave.
            estados.Remove(4);
            estados[5] = "Amazonas";
            foreach (var i in estados)
            {
                Console.WriteLine($"Chave{i.Key}, Estado: {i.Value}");
            }
            int validar = 1;
            Console.WriteLine("Vamos validar a chave: " + validar);

            if (estados.ContainsKey(validar))
            {
                Console.WriteLine("Valor existente");
            }
            else
            {
                Console.WriteLine("Valor não encontrado");
            }

            Console.WriteLine($"Agora, ao invés de tratar a chave, vamos exibir o valor da chave 1: {estados[1]}");

            #endregion
        }
        }
    }
