namespace GrageApplikation
{
    class Boat : Vehicle
    {
        private int boatType; 

        public int BoatType { get { return boatType; } set { boatType = value; } }

        public Boat()
        {
            VehicleTypeName = "Boat";
            VehicleTypeId = "H";
        }
    }
}