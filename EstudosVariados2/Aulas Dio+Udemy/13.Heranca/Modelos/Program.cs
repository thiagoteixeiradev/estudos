using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;
using ExemploPOO.Modelos;
using ExemploPOO.Object;
using ExemploPOO.Caixa_Encapsulamento;

namespace ExemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Romario"); //Tive que passar no construtor, por causa da minha construct
            a1.Idade = 31;
            a1.Nota = 10;
            a1.Apresentar();

            //Aula polimorfismo
            Professor p1 = new Professor("Eduardo"); //Tive que passar no construtor por causa da construct
            p1.Idade = 30;
            p1.Salario = 1000;
            p1.Apresentar();

            //Aula abstração
            //Conta c = new Conta(); //Não é possível instânciar conta diretamente, pois ela é abstrata
            Corrente c = new Corrente();
            c.Creditar(500);
            c.ExibirSaldo();

            //Aula sobre a classe object
            //Computador c = new Computador();
            //c

            //Aula sobre interface
            Console.WriteLine("Agora vamos para interfaces");
            ICalculadora calc = new Calculadora();
            Console.WriteLine($"Vamos somar com a interface da minha calculadora: {calc.Somar(10,15)}");

            //Aula sobre Encapsulamento
            Console.WriteLine("Agora vamos para Encapsulamento");
            EncapCaixa ec = new EncapCaixa();
            ec.Depositar(500);
            ec.Sacar(250);

        }
    }
}
