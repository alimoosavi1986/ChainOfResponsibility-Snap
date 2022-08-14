using ChainOfResponsibility_Snap.DTO;
using ChainOfResponsibility_Snap.MainHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Snap.Chain
{
    public class CheckUserActiveUser : ATakeATaxiHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (requestContext.UserId != 1)
            {
                Console.WriteLine("User Not Active");
                return new ResponseContext
                {
                    IsSuccess = false,
                    Message = "User not Active"
                };
            }
            else if (successor != null)
            {
                Console.WriteLine("User Is Active");
                return successor.Execute(requestContext);
            }
            else
            {
                return new ResponseContext
                {
                    IsSuccess = false,
                    Message = "error"
                };
            }
        }
    }
}
