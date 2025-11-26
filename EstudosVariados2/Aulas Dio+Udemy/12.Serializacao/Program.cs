using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static Serializacao.Vendas;

namespace Serializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Digite 1 Para serializar um único objeto,\ndigite 2 para serializar uma coleção,\nDigite 3 Para extrair dados de um arquivo .json");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op) {
                case 1:
                    SerializarUmaVar();
                    break;
                case 2:
                    SerializarColecao();
                    break;
                case 3:
                    ReceberArquivo();
                    break;
            }
        }

        static void SerializarUmaVar()
        {

        DateTime dataAtual = DateTime.Now;
            
        Vendas v1 = new Vendas(1, "Material de Escritório", 25.00M, dataAtual);
        //Criei os dados que quero serializar

        string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
        //usei meu pacote para serializar, o .Indented organizou a quebra de linha


        File.WriteAllText("\\Arquivos\\vendas.json", serializado);
        //Salvei meus dados em um arquivo


        Console.WriteLine(serializado);

        }
        
        static void SerializarColecao()
        {
            {
                List<Vendas> listaVendas = new List<Vendas>();
                //Criei minha colecao

                DateTime dataAtual = DateTime.Now;
                    
                Vendas v1 = new Vendas(1, "Material de Escritório", 25.00M, dataAtual);
                Vendas v2 = new Vendas(1, "Material de Aula", 50.00M, dataAtual);
                //Criei os dados que quero serializar

                listaVendas.Add(v1);
                listaVendas.Add(v2);

                string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
                //usei meu pacote para serializar, o .Indented organizou a quebra de linha


                File.WriteAllText("vendas2.json", serializado);
                //Salvei meus dados em um arquivo


                Console.WriteLine(serializado);

            }
        }
        public static void ReceberArquivo()
        {
            string Arquivo = File.ReadAllText("D:\\Arquivos\\GitHub\\Estudos.net\\14. Serialização\\Serializacao\\Serializacao\\Arquivos\\/vendas.json");
            List<Extrair> listaVenda = JsonConvert.DeserializeObject<List<Extrair>>(Arquivo);

            foreach (Extrair vendaex in listaVenda){

                Console.WriteLine($"Id: {vendaex.Id}, Produto: {vendaex.Produto} Preço: {vendaex.Preco} Data:{vendaex.DataVenda}");
            }
        }
    }
}
