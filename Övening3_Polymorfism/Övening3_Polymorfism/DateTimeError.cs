using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övening3_Polymorfism
{
    class DateTimeError : UserError
    {
        public override string UEMessage()
        {
            return "You have entered wrong Date Time Format";
        }
    }
}
