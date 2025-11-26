using VendaExtensao;
using System;
using VendaExtensao.ProdutosExtensao;

namespace VendasExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p1 = new Produtos(1, "Caneta", "Caneta Azul", 2.00M, 3.40M, 100, true);

            Console.WriteLine($"Produto = {p1.Nome}, Lucro: {p1.MargemLucro()}");

            Console.ReadLine();
        }
    }
}