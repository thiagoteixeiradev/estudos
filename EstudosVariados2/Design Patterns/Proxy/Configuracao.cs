using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Configuracao : IConfiguracao
    {
        public void Atualizar()
        {
            Console.WriteLine("Configurações Atualizadas");
        }

        public string GetConfig(string key)
        {
            Random rnd = new Random();
            return $"Valor da Configuração {key} é : {rnd.NextInt64()}";
        }

        public void Inicializar()
        {
            Console.WriteLine("Configurações Inicializadas");
        }

        public void SetConfig(string key, string value)
        {
            Console.WriteLine($"Configurações registradas.{key}:{value}");
        }
    }
}
