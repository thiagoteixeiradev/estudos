using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOSimples
{
    internal class Pessoa //Classe
    {
        //Variaveis
        public string nome;
        public int idade;
        public string genero;

        //Método
        public void Identificar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, e tenho {idade} anos, meu gênero é: {genero}");
        }

        //Isto aqui, é um construtor
        public Pessoa()
        {
        }
        //este é um construtor com parâmetros
        public Pessoa(string nome, int idade, string genero )
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public Pessoa(string nome) 
        {
            this.nome = nome; 
        }
    }
}
