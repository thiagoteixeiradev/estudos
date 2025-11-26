using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;


        //Este é meu construtor
        public Pessoa()
        {
            nome = "Romario";
            sobrenome = "Braz";
            anoNascimento = 1994;
            idade = 31;
        }
        //Este é meu construtor com sobrecarga
        public Pessoa(string nome, string sobrenome, int anoNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            this.idade = Idade();
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            anoNascimento = 2007;
            this.idade = Idade();
        }
        private int Idade()
        {
            return 2025 - anoNascimento;
        }

    }
}
