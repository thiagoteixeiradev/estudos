using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public /*sealed*/ class Professor : Pessoa //Minha Classe Professor Herda de Pessoa
        //O sealed define que a classe é uma instância final, e não pode ter outras classes filhas.
    {
        public Professor(string nome) : base(nome)
        {
        }
        //Essa construct foi feito para que todas as heranças tenham que ter nome na parametrização
        public int Salario;

        public /*sealed*/ override void Apresentar()
            //Termo de selado também pode ser usado no método.
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade}, e recebo {Salario}");
        }
    }
}
