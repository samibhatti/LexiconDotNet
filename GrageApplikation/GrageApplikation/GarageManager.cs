using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrageApplikation
{
    class GarageManager
    {
        private Vehicle[] vehicles;
        private int count;
        private string parkingSlotNo;

        public int Count { get { return count; } set { count = value; } }
        public string ParkingSlotNo { get { return parkingSlotNo; } set { parkingSlotNo = value; } }
        //public GarageManager(int parkingSlots )
        public GarageManager(int parkingSlots )
        {
           Count = parkingSlots;
           vehicles = new Vehicle[Count];
           ParkingSlotNo = parkingSlotNo;
           
        }
              
        public void setParkingSlots(Garage g, int p)
        {
            g.ParkingSlots = p;
        }

        public Garage createParkingSlots(int p)
        {
            Garage garage = new Garage();
            garage.ParkingSlots = p;

            return garage;
        }

        public void parkVehicle(Vehicle vehicle)
        {
            string type;
           
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    ParkingSlotNo =  vehicle.vT + i;
                    // Console.WriteLine("P.No: A"+parkingSlot);
                    vehicle.pN = ParkingSlotNo;
                    Count -= 1;
                    break;
                }
            }
        }

        public void unparkVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == vehicle)
                {
                    vehicles[i] = null;
                    Count += 1;
                } 
            }
        }

        public Vehicle[] listParkedVehicle()
        {
            int count = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle != null)
                    count += 1;
              //  Console.WriteLine("Total Vehicles: "+ count);
            }

            Vehicle[] array = new Vehicle[count];

            int index = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    array[index] = vehicle;
                    index += 1;
                }
            }
            return array;
        }
    }
}
