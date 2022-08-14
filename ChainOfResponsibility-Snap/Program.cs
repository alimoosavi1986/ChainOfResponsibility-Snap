using ChainOfResponsibility_Snap.Chain;
using ChainOfResponsibility_Snap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Snap
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckUserActiveUser checkUserActiveUser = new CheckUserActiveUser();
            CreateOrder createOrder = new CreateOrder();
            SendOrderToDriver sendOrderToDriver = new SendOrderToDriver();
            CheckTest checkTest = new CheckTest();

            checkUserActiveUser
                .SetSuccessor(createOrder)
                .SetSuccessor(sendOrderToDriver)
                .SetSuccessor(checkTest);
               


            checkUserActiveUser.Execute(new RequestContext
            {
                UserId = 1,
                Origin = new Point { Lat = 53.3636, Lng = 54.22 },
                Destination = new Point { Lat = 53.3636, Lng = 54.22 },
            });


            Console.Read();
        }
    }
}
