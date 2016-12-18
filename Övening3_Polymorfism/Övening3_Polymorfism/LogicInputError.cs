using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övening3_Polymorfism
{
    class LogicInputError : UserError
    {
        public override string UEMessage()
        {
            return "You have tried to use a numeric input instead of Boolean value";
        }
    }
}
