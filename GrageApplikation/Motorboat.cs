namespace GrageApplikation
{
    class Motorboat : Vehicle
    {
        private int numberOfEngines;
        private int cylinderVolume;
        private string fuelType;

        public int NumberOfEngines { get { return numberOfEngines; } set { numberOfEngines = value; } }
        public int CylinderVolume { get { return cylinderVolume; } set { cylinderVolume = value; } }
        public string FuelType { get { return fuelType; } set { fuelType = value; } }

        public Motorboat()
            {
                VehicleTypeName = "Motorboat";
                VehicleTypeId = "E";
        }
    }
}