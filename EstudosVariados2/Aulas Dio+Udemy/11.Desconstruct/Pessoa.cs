using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconstruindo
{
    internal class Pessoa
    {
        private string _nome;
        private string _sobrenome;

        public string Nome
        {
            get => _nome.ToUpper();
            set {
                if (value == "")
                {
                    Console.WriteLine("Nome não pode estar vazio!");
                }
            }
        }
        public string Sobrenome
        {
            get => _sobrenome.ToUpper();
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Sobrenome não pode estar vazio!");
                }
            }
        }

        public Pessoa ()
        {

        }

        public Pessoa(string  nome, string sobrenome)
        {

        }
        public void Deconstruct(out string nome, out  string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

    }
}
