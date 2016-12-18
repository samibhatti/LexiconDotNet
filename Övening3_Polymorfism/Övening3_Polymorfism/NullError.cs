using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övening3_Polymorfism
{
    class NullError : UserError
    {
        public override string UEMessage()
        {
            return "You have tried to pass a null value";
        }
       
    }
}
