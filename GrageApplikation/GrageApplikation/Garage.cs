namespace GrageApplikation
{
    internal class Garage
    {
        private const float area = 4000;
        private const int capacity = 800;
        private int parkingSlots;

        public int ParkingSlots { get { return parkingSlots; } set {parkingSlots = value; } }
        public int Capacity { get { return capacity; } set {; } }
        public Garage()
        {
        }
    }
}