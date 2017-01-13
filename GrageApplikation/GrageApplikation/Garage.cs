using System;

namespace GrageApplikation
{
    internal class Garage
    {
        private const float area = 4000;
        private const int capacity = 10;
        private int parkingSlots;
//        private Array[] parkingSlotsNumber;

        public int ParkingSlots { get { return parkingSlots; } set {parkingSlots = value; } }
        public int Capacity { get { return capacity; } set {; } }

        public Garage()
        {
            ParkingSlots = 10;
            //ParkingSlotsNumber = parkingSlotsNumber;
        }

        
    }
}