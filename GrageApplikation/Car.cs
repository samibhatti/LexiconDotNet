using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrageApplikation
{
    internal class Car : Vehicle
    {
        private int noOfTyres;
        private int cylinderVolume;
        private string fuelType;
      
        public int CylinderVolume { get { return cylinderVolume; } set { cylinderVolume = value; } }
        public int NoOfTyres { get { return noOfTyres; } set { noOfTyres = value; } }
        public string FuelType { get { return fuelType; } set { fuelType = value; } }

        public Car()
        {
            VehicleTypeId = "A";
            VehicleTypeName = "Car";
        }
    }
}