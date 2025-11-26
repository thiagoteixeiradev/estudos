using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class JanelaAbstrata
    {
        protected IJanelaBridge janela;

        public JanelaAbstrata(IJanelaBridge j)
        {
            janela = j;
        }

        public void desenharJanela(string titulo)
        {
            janela.desenharJanela(titulo);
        }

        public void desenhaBotao(string titulo)
        {
            janela.desenharBotao(titulo);
        }

        public abstract void desenhar();
    }
}
