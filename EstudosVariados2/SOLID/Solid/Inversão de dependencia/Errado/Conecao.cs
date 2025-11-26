using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversão_de_dependencia.Errado
{
    public class ConecaoErrada
    {
        public ConecaoErrada() 
        {
            conexaoBanco = new MySqlConnection();
        }
    }
}
