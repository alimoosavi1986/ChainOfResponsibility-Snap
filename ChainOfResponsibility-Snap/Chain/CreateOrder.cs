using ChainOfResponsibility_Snap.DTO;
using ChainOfResponsibility_Snap.MainHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Snap.Chain
{
    public class CreateOrder : ATakeATaxiHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            bool orderCreated = true;
            if (orderCreated)
            {
                Console.WriteLine("Order Created.....");
                if (successor != null)
                {
                    return successor.Execute(requestContext);
                }
            }
            return new ResponseContext
            {
                IsSuccess = false,
                Message = "Error Order Created "
            };
        }
    }
}
