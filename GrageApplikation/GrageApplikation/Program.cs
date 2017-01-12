using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrageApplikation
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage garage = new Garage();
            Console.WriteLine("Garage Capacity: " + garage.Capacity);

            GarageManager manager = new GarageManager(10);

            Garage garage0 = manager.createParkingSlots(100);
            Console.WriteLine("Motorcycle Parking Slots: " + garage0.ParkingSlots);
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            Car car1 = vehicleName = "Mazda";
            car2.vehicleName = "Volvo";
            car3.vehicleName = "Audi";

            manager.parkVehicle(car1);
            manager.parkVehicle(car2);
            manager.parkVehicle(car3);
            Vehicle[] array = manager.listParkedVehicle();
            Console.WriteLine("List: " + manager.listParkedVehicle());
            Console.WriteLine("List: " + array);
        }


    }
}
