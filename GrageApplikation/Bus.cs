using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrageApplikation
{
    internal class Bus : Vehicle
    {
        private string fuelType;
        private int cylinderVolume;
        private int noOfTyres;

        public int NoOfTyres { get { return noOfTyres; } set {noOfTyres = value; } }
        public int CylinderVolume { get { return cylinderVolume; } set { cylinderVolume = value; } }
        public string FuelType { get { return fuelType; } set { fuelType = value; } }

        public Bus()
        {
            VehicleTypeName = "Bus";
            VehicleTypeId = "G";
        }
    }
}