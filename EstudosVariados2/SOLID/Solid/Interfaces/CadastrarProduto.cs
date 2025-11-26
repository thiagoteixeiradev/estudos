using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Interfaces
{
    internal class CadastrarProduto : IPersistencia
    {
        public void EnviarEmail()
        {
            throw new NotImplementedException();
            //está sendo obrigado a implementar algo que não vai ser usado.
        }

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
