namespace GrageApplikation
{
    internal class Motorcycle : Vehicle
    {
        private int noOfTyres;
        private int cylinderVolume;
        private string fuelType;

        public int NoOfTyres { get { return noOfTyres; } set { noOfTyres = value; } }
        public int CylinderVolume { get { return cylinderVolume; } set { cylinderVolume = value; } }
        public string FuelType { get { return fuelType; } set { fuelType = value; } }

        public Motorcycle()
        {
            VehicleTypeName = "Motorcycle";
            VehicleTypeId = "B";
        }
    }
}