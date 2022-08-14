using ChainOfResponsibility_Snap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Snap.MainHandler
{

    public interface IHandler
    {
        IHandler SetSuccessor(IHandler handler);
        ResponseContext Execute(RequestContext requestContext);
    }
}
