using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Snap.DTO
{
    public class RequestContext
    {
        public int UserId { get; set; }
        public Point Origin { get; set; }
        public Point Destination { get; set; }

    }
}
