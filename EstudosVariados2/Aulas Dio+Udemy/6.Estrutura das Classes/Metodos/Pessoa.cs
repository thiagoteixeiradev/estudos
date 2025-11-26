using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Metodos
{
    internal class Pessoa
    {
        public Pessoa() //Isto é um construtor, note que ele não tem tipo do retorno e tem o mesmo nome da classe
        { 
        
        }
        public Pessoa(string nome, string sobrenome) //Outro construtor
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {

            get => _nome; //Isto é uma body expression
            //{ return _nome.ToUpper(); }
            set { 
                if(value == "") {
                    //Caso o valor seja vazio, o programa irá encerrar nesta excessão
                    throw new ArgumentException("Nome vazio!");
                }
                _nome = value;
                }
        }
        public int Idade { 

            get => _idade;
            set
            {
                if (value < 0) {
                    throw new ArgumentException("A idade não pode ser menor do que 0");
                }
                _idade = value;
            }
        }

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá");
        }

        //Passagem de valor por referencia
        public void SomarRef(ref int valor)
        {
            //Iremos fazer isso por referencia
            valor += 10;
            Console.WriteLine("O valor final é: " + valor);
        }


        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        //Sobrecarga de métodos

        //Mesmos méotodos, mas com paramestros diferentes.
        public void Cumprimentar(string nome)
        {
            Console.WriteLine($"Olá, eu sou {NomeCompleto} e estou te cumprimentando");
        }
        public void Cumprimentar(string nome, int hora)
        {
            Console.WriteLine($"Olá, eu sou {NomeCompleto} e estou te cumprimentando");
            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            Console.WriteLine(mensagem);

        }
        public bool Comparar(int num1, int num2) 
        {
            return num1 == num2;
        }

        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
    }
}
