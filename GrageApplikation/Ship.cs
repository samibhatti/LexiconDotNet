namespace GrageApplikation
{
    internal class Ship : Vehicle
    {
        private int numberOfEngines;
        private string fuelType;
        private int noOfPropeller;
   
        public int NumberOfEngines { get { return numberOfEngines; } set { numberOfEngines = value; } }
        public string FuelType { get { return fuelType; } set { fuelType = value; } }
        public int NoOfPropeller { get { return noOfPropeller; } set { noOfPropeller = value; } }

        public Ship()
        {
            VehicleTypeName = "Ship";
            VehicleTypeId = "F";
        }
    }
}