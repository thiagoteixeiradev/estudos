using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversão_de_dependencia.Correto
{
    public interface IDatabaseConnection
    {
        void Conectar();
    }
}
