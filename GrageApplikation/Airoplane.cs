namespace GrageApplikation
{
    class Airoplane : Vehicle
    {
       
        private int noOfTyres;
        private int totalThrust;
        private int numberOfEngines;
        private string fuelType;
        private int flightAltitude;
        private int wingSpanLength;

       
        public int NoOfTyres { get { return noOfTyres; } set { noOfTyres = value; } }
        public int NumberOfEngines { get { return numberOfEngines; } set { numberOfEngines = value; } }
        public string FuelType { get { return fuelType; } set { fuelType = value; } }
        public int TotalThrust { get { return totalThrust; } set { totalThrust = value; } }
        public int FlightAltitude { get { return flightAltitude; } set { flightAltitude = value; } }
        public int WingSpanLength { get { return wingSpanLength; } set { wingSpanLength = value; } }

        public Airoplane()
        {
            VehicleTypeName = "Airoplane";
            VehicleTypeId = "C";
        }
    }
}