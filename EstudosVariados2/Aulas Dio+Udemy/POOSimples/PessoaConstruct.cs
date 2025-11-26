using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOSimples
{
    public class PessoaConstruct
    {
        private int idade;
        private string nome;
        private string genero;
        public int Idade
        {
            set { if(value < 18)
                {
                    Console.WriteLine("Idade deve ser maior do que 18.");
                }
             else
                {
                    this.idade = value;
                }
            }
            get {  return idade; }
        }

        public string Nome { get; set; }

        public PessoaConstruct(string nome)
        {
            Nome = nome;
        }

        public string Genero { set { genero = value;
            System.Console.WriteLine(genero);
            } }
    }
}
