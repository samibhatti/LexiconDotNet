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

            var slots = garage.ParkingSlots;
            GarageManager manager = new GarageManager(slots);

            // Garage garage0 = manager.createParkingSlots(100);
            // Console.WriteLine("Motorcycle Parking Slots: " + garage0.ParkingSlots);

            Console.WriteLine("Slot Available: " + manager.Count);


            var car1 = new Car("Mazda");
            var car2 = new Car("Volvo");
            var car3 = new Car("Audi");
            var car4 = new Car("Toyota");
            var motorCycle1 = new Motorcycle("Honda");
            var motorCycle2 = new Motorcycle("BMW");
            var motorCycle3 = new Motorcycle("Vespa");
            var motorCycle4 = new Motorcycle("Hero");
            var motorboat = new Motorboat("Zero");
            var ship1 = new Ship("Viking");
            var ship2 = new Ship("Jordgården");
            var ship3 = new Ship("Siljaline");
            var bicycle1 = new Bicycle("City");
            var bicycle2 = new Bicycle("City");
            var bicycle3 = new Bicycle("Tedy");
            var bicycle4 = new Bicycle("Sport");

            manager.parkVehicle(car1);
           manager.parkVehicle(car2);
            manager.parkVehicle(car3);
            manager.parkVehicle(car4);
            manager.parkVehicle(motorCycle1);
            manager.parkVehicle(motorCycle2);
            manager.parkVehicle(motorCycle3);
            manager.parkVehicle(motorCycle4);
           manager.parkVehicle(motorboat);
            manager.parkVehicle(ship1);
            manager.parkVehicle(ship2);
            manager.parkVehicle(ship3);
            manager.parkVehicle(bicycle1);
            manager.parkVehicle(bicycle2);
            manager.parkVehicle(bicycle3);
            manager.parkVehicle(bicycle4);


            Vehicle[] array = manager.listParkedVehicle();
           // Console.WriteLine("P N: A" + pN);

            Console.WriteLine("Vehicle Parked:");
            Console.WriteLine("{0,-15}{1,-10}{2,-10}", "Vehicle Type", "P.No", "Vehicle Name");

            foreach (Vehicle vehicle in array)
            {
                //Console.WriteLine("{0,10}{1,10}{2,10}", "Vehicle Type", "P N: A", "Vehicle Name");
                Console.WriteLine("{0,-15}{1,-10}{2,-10}", vehicle.vehicleType, vehicle.pN, vehicle.vehicleName);
//              Console.WriteLine("Motorcycle List: " + vehicle.VehicleName);

            }
            Console.WriteLine();
            Console.WriteLine("Slot Available: " + manager.Count);
            Console.WriteLine(
                );
            manager.unparkVehicle(motorCycle4);
            manager.unparkVehicle(car1);
            manager.unparkVehicle(bicycle4);

            Vehicle[] array1 = manager.listParkedVehicle();

            Console.WriteLine("Vehicle Parked:");
            Console.WriteLine("{0,-15}{1,-10}{2,-10}", "Vehicle Type", "P.No", "Vehicle Name");

            foreach (Vehicle vehicle in array1)
            {
                //Console.WriteLine("{0,10}{1,10}{2,10}", "Vehicle Type", "P N: A", "Vehicle Name");
                Console.WriteLine("{0,-15}{1,-10}{2,-10}", vehicle.vehicleType, vehicle.pN, vehicle.vehicleName);
                //              Console.WriteLine("Motorcycle List: " + vehicle.VehicleName);

            }
            Console.WriteLine();
            Console.WriteLine("Slot Available: " + manager.Count);

            /*   Vehicle[] array1 = manager.listParkedVehicle();
               //Console.WriteLine("List: " + manager.listParkedVehicle());

               Console.WriteLine("Count: " + manager.Count);
               Console.WriteLine("Vehicle Type      :     Vehicle Name");

               foreach (Vehicle vehicle in array1)
               {
                   Console.WriteLine(vehicle.vehicleType + "   :    " + vehicle.vehicleName);
                // Console.WriteLine("Motorcycle List: " + vehicle.VehicleName);

               }*/
        }


    }
}
