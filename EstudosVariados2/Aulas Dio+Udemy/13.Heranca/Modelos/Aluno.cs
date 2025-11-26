using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Aluno : Pessoa //é Aqui que defino a herança, no caso, aluno herda de pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade}, e sou um aluno {Nota}");
        }
    }
}
