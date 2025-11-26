using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serializacao
{
    internal class Vendas
    {

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public Vendas(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;

    }
        public class Extrair{
            public int Id { get; set; }
            //Caso o nome de um campo do json tenha _, como "Nome_Produto, posso adicionar: [JsonProperty("Nome_Produto")] antes da declaração.
            public string Produto { get; set; }
            public decimal Preco { get; set; }
            public DateTime DataVenda { get; set; }
        }

}
}
