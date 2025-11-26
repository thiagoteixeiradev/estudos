using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Servidor_de_Chat
{
    //Trata os eventos de mudança de status
    public class StatusChangeEvent : EventArgs
    {
        //armazenar mensagem descrevendo o evento
        private string eventMsg;

        //retorna e define uma mensagem para o evento
        public string EventoMensagem
        {
            get { return eventMsg; }
            set { eventMsg = value; }
        }

        public StatusChangeEvent(string eventMsg)
        {
            this.eventMsg = eventMsg;
        }
    }
}
