using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IPersistencia
    {
        void ValidarDados();
        void SalvarDados();
        void EnviarEmail();
    }
}
