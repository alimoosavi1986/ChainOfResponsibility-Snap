using ChainOfResponsibility_Snap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Snap.MainHandler
{
    public abstract class ATakeATaxiHandler : IHandler
    {
        protected IHandler successor;
        public abstract ResponseContext Execute(RequestContext requestContext);

        public IHandler SetSuccessor(IHandler handler)
        {
            this.successor = handler;
            return successor;
        }

    }
}
