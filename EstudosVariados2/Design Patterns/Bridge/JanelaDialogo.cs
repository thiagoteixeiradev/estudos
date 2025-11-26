using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class JanelaDialogo : JanelaAbstrata
    {
        public JanelaDialogo(IJanelaBridge janela) : base(janela) { }
        public override void desenhar()
        {
            desenharJanela("Atenção! deseja encerrar sem salvar?");
            desenhaBotao("Sim");
            desenhaBotao("Não");
            
        }
    }
}
