using Inversão_de_dependencia.Correto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversão_de_dependencia.Errado
{
    public class ConecaoCerta : IDatabaseConnection
    {
        public void Conectar()
        {
            //codigo da conexão
        }
    }
}
