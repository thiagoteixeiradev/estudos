using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LogSingleton
    {
        private static LogSingleton? Instancia;

        private LogSingleton()
        {

        }
        public static LogSingleton GetInstance
        {
            get
            {
                if (Instancia == null) { Instancia = new(); }
                return Instancia;
            }
        }

        public void Write(string Mensagem)
        {
            Console.WriteLine(Mensagem);
        }
    }
}
