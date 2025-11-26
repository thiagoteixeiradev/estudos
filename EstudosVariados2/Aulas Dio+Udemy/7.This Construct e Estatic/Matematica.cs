using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    static class Matematica // declarei como estática, e preciso declarar todos os membros como estático
    {
        public static int taxa;
        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }
        public static int Diminiuir(int valor)
        {
            return valor - taxa;
        }
    }
}
