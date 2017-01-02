using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övening3_Arv
{
    class Horse : Animal
    {
        private string sound = "neighing";
        private string move = "Gallop";
        private string gallopLength;

        public Horse()
        {

        }

        public string Sound { get; set; }
        public string Move { get; set; }
        public string GallopLength { get; set; }
    }
}
