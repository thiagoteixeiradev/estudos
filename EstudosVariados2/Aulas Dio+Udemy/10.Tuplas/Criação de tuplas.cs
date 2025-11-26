using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    internal class Criação_de_tuplas
    {
        public static void Criando_tuplas (){
            //Uma tupla armazena vários tipos de dados
            (int, string, string) exemploTupla = (01, "Romario", "Braz");
            //Podemos escrever ou acessar esses dados assim:
            Console.WriteLine($"{exemploTupla.Item1} + {exemploTupla.Item2} + {exemploTupla.Item3}");
            //Outro meio de declarar tupla
            ValueTuple<int, string, string, string> exemploTupla2 = (02, "Thiago", "Ferreira", "Diogo");
            Console.WriteLine($"{exemploTupla2.Item1} + {exemploTupla2.Item2} + {exemploTupla2.Item3} + {exemploTupla2.Item4}");
            //Mais um modo de criar outra tupla
            var exemploTupla3 = Tuple.Create(02, "Gustavo", "Diogenes", "Lima");
            Console.WriteLine($"{exemploTupla3.Item1} + {exemploTupla3.Item2} + {exemploTupla3.Item3} + {exemploTupla3.Item4}");
            //ainda no nosso primeiro exemplo, podemos fazer o seguinte
            (int chave, string nome, string sobrenome) exemploTupla4 = (01, "Romario", "Braz");
            Console.WriteLine($"{exemploTupla4.nome} + {exemploTupla4.sobrenome} + {exemploTupla4.chave}");

            //Tuplas em outras classes e retorno de tupla
        }
    }
}
