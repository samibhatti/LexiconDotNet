namespace GrageApplikation
{
    class Helicopter : Vehicle
    {
        private string fuelType;
        private int totalThrust;
        private int noOfTyres;
        private int numberOfEngines;
        private int flightAltitude;

        public string FuelType { get { return fuelType; } set { fuelType = value; } }
        public int NoOfTyres { get { return noOfTyres; } set { noOfTyres = value; } }
        public int NumberOfEngines { get { return numberOfEngines; } set { numberOfEngines = value; } }
        public int TotalThrust { get { return totalThrust; } set { totalThrust = value; } }
        public int FlightAltitude { get { return flightAltitude; } set { flightAltitude = value; } }


        public Helicopter()
        {
            VehicleTypeName = "Helicopter";
            VehicleTypeId = "I";
        }
    }
}