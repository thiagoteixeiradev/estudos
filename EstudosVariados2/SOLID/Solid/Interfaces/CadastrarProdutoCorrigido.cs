using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Interfaces
{
    internal class CadastrarProdutoCorrigido : IPersistenciaProdutos
    {
        public void SalvarDados()
        {
            Console.WriteLine("Salva Dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Valida Dados");
        }
    }
}
