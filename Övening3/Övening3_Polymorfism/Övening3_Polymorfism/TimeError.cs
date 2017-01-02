using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övening3_Polymorfism
{
    class TimeError : DateTimeError
    {
        public string UEMessage()
        {
            return "You have entered incorrect Time format!";
        }
    }
}
