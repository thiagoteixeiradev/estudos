using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Handler
    {
        protected Handler sucessor;

        public void SetSucessor(Handler sucessor)
        {
            this.sucessor = sucessor;
        }

        public abstract void HandleRequest(int request);
    }
}
