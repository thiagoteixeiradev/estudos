using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TuplaArquivo arquivo = new TuplaArquivo();

            var (Sucesso, LinhasArquivo, QuantidadeLinhas) = arquivo.LerArquivo("D:\\Arquivos\\GitHub\\Estudos.net\\12.Tuplas\\Tuplas\\Tuplas\\dados.txt");
            //Caso eu queira descartar um retorno, basta eu trocar a variavel dele por "_"
            if (Sucesso)
            {

                foreach (string linha in LinhasArquivo)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("Não foi possível ler o arquivo");
            }
        }
    }
}
