namespace GrageApplikation
{
    internal class Bicycle : Vehicle
    {
        
        private int noOfPedels;
        
        public int NoOfPedels { get { return noOfPedels; } set { noOfPedels = value; } }

        public Bicycle()
        {
            VehicleTypeName = "Bicycle";
            VehicleTypeId = "D";
        }
    }
}