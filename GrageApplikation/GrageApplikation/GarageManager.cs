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

        public GarageManager(int parkingSlots )
        {
            vehicles = new Vehicle[parkingSlots];
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
            for (int i = 0; i < vehicles.Length; i++)
            {
                Car car = new Car();
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;

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
                    //decrement parking slot
                }
            }
        }

        public Vehicle[] listParkedVehicle()
        {
            int count = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle != null)
                    Console.WriteLine(vehicle.vehicleName);
                    count += 1;
            }

            Vehicle[] array = new Vehicle[count];

            int index = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                array[index] = vehicle;
            }
            return array;
        }
    }
}
