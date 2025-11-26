using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ConfiguracaoProxy : IConfiguracao
    {
        Configuracao configuracao = new();
        public void Inicializar()
        {
            configuracao.Inicializar();
        }

        public string GetConfig(string key)
        {
            return configuracao.GetConfig(key);
        }

        public void SetConfig(string key, string value)
        {
            configuracao.SetConfig(key, value);
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }
    }
}
