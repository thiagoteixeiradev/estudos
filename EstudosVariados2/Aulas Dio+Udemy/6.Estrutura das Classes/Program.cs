using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Metodos; // 1. Chama o namespace

namespace Cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Pessoa pessoa = new Pessoa(); // 2 Instância
            //Agora pode sentar o aço.
            pessoa.Nome = "Romario";
            //pessoa.Idade = 31;
            pessoa.Sobrenome = "Rocha";

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Eduardo";
            pessoa2.Sobrenome = "Silva";
            */
            //Ao inves de fazer deste modo, instânciando, agora podemos usar nossos construtores
            Pessoa p1 = new Pessoa(nome: "Romario", sobrenome: "Braz");//poderia fazer mesmo sem chamar o nome da string
            Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Silva");//ex ("Eduardo", "Silva")

            Curso nCurso  = new Curso();
            nCurso.NomeCurso = "Inglês";
            nCurso.Alunos = new List<Pessoa>();

            nCurso.AdicionarAluno(p1);
            nCurso.AdicionarAluno(p2);
            nCurso.ListarAlunos();
            Console.WriteLine("Um aluno irá te cumprimentar");
            p1.Cumprimentar();
            int valor1 = 0;
            p1.SomarRef(ref valor1); // aqui está a referencia
            Console.WriteLine("Este mesmo aluno irá somar o valor que você digitar + 10");
            Console.WriteLine("Digite um valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            p1.SomarRef(ref valor1);



            /*
            Console.WriteLine($"Meu nome é: {pessoa.Nome}");
            Console.WriteLine($"Meu sobrenome é: {pessoa.Sobrenome}");
            Console.WriteLine($"Meu nome completo é: {pessoa.NomeCompleto}");
            Console.WriteLine($"Minha idade é: {pessoa.Idade}");
            */

            p1.Cumprimentar();
            p1.Cumprimentar("Otávio");
            p1.Cumprimentar("João", 18);

            bool r1 = p1.Comparar(100, 50 + 50);
            bool r2 = p1.Comparar("Joao", "JOAO");

            Console.WriteLine($"Minha primeira condição foi: {r1}, minha segunda condição foi: {r2}");
        }
    }
}
