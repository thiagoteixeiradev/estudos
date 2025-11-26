using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Pessoa
    {
        //Aula construtor por herança
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        //Essa construct foi feito para que todas as heranças tenham que ter nome na parametrização

        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Nota { get; set; }

        public virtual void Apresentar() //o virtual habilita o polimorfismo, torna ele sobreescrevível
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade}");
        }
    }
}
