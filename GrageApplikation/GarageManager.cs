using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrageApplikation
{
    class GarageManager
    {
        Garage<Vehicle> garage;
        public GarageManager(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            Console.WriteLine("Parking Slots Available: " + garage.Count);
        }

        public void listParkedVehicle()
        {
            Vehicle[] array = garage.listParkedVehicle();
            Console.WriteLine("Vehicle Parked:");
            printVehicle(array);
        }

        public void listSpecificTypeParkedVehicle(Array typeArray)
        {
            foreach (string type in typeArray)
            {
                Vehicle[] array = garage.listSpTypeVehicle(type);
                if (array.Count() != 0)
                {
                    printVehicle(array);
                    Console.WriteLine("Parked Vehicles of type <" + type + ">: " + array.Count());
                }
                else
                {
                    Console.WriteLine("Parked Vehicles of type <" + type + ">: " + array.Count());
                }
            }
        }

        public void unParkVehicle(string name)
        {
            garage.unparkVehicle(name);
            listParkedVehicle();
        }

        public void findVehicle(string name)
        {
            Vehicle[] array = garage.find(name);
            Console.WriteLine("Search Output: ");
            printVehicle(array);
        }

        public void parkVehicle(Vehicle vehicle, string name, string regNr, string color, int length, int seats, int tyres, int cc, string fuel, int engines, int thrust, int altitude)
        {
            vehicle.VehicleName = name;
            vehicle.RegNr = regNr;
            vehicle.Color = color;
            vehicle.VehicleLength = length;
            vehicle.NumberOfSeats = seats;

            switch (vehicle.VehicleTypeName)
            {
                case "Car":
                    ((Car)vehicle).NoOfTyres = tyres;
                    ((Car)vehicle).CylinderVolume = cc;
                    ((Car)vehicle).FuelType = fuel;
                    break;
                case "Motorcycle":
                    ((Motorcycle)vehicle).NoOfTyres = tyres;
                    ((Motorcycle)vehicle).CylinderVolume = cc;
                    ((Motorcycle)vehicle).FuelType = fuel;
                    break;
                case "Motorboat":
                    ((Motorboat)vehicle).CylinderVolume = cc;
                    ((Motorboat)vehicle).FuelType = fuel;
                    break;
                case "Ship":
                    ((Ship)vehicle).FuelType = fuel;
                    ((Ship)vehicle).NumberOfEngines = engines;
                    break;
                case "Airoplane":
                    ((Airoplane)vehicle).NoOfTyres = tyres;
                    ((Airoplane)vehicle).FuelType = fuel;
                    ((Airoplane)vehicle).NumberOfEngines = engines;
                    ((Airoplane)vehicle).TotalThrust = thrust;
                    ((Airoplane)vehicle).FlightAltitude = altitude;
                    break;
                case "Bus":
                    ((Bus)vehicle).NoOfTyres = tyres;
                    ((Bus)vehicle).CylinderVolume = cc;
                    ((Bus)vehicle).FuelType = fuel;
                    break;
                case "Helicopter":
                    ((Helicopter)vehicle).NoOfTyres = tyres;
                    ((Helicopter)vehicle).FuelType = fuel;
                    ((Helicopter)vehicle).NumberOfEngines = engines;
                    ((Helicopter)vehicle).TotalThrust = thrust;
                    ((Helicopter)vehicle).FlightAltitude = altitude;
                    break;
            }

            garage.parkVehicle(vehicle);

            listParkedVehicle();


        }

        public void printVehicle(Vehicle[] array)
        {

            Console.WriteLine();

            foreach (Vehicle vehicle in array)
            {
                if (vehicle != null)
                {
                    Console.Write("Type: " + vehicle.VehicleTypeName + " P.No.: " + vehicle.ParkingLotNo + " Reg.No: " + vehicle.RegNr + " Name: " + vehicle.VehicleName + " Color: " + vehicle.Color + " Length: " + vehicle.VehicleLength + " Seats: " + vehicle.NumberOfSeats);

                    switch (vehicle.VehicleTypeName)
                    {
                        case "Car":
                            Console.WriteLine(" No.Of Tyres: " + ((Car)vehicle).NoOfTyres + " CylinderVolume: " + ((Car)vehicle).CylinderVolume + " Fuel Type: " + ((Car)vehicle).FuelType + "\n");
                            break;
                        case "Motorcycle":
                            Console.WriteLine(" No.Of Tyres: " + ((Motorcycle)vehicle).NoOfTyres + " CylinderVolume: " + ((Motorcycle)vehicle).CylinderVolume + " Fuel Type: " + ((Motorcycle)vehicle).FuelType + "\n");
                            break;
                        case "Motorboat":
                            Console.WriteLine(" Fuel Type: " + ((Motorboat)vehicle).FuelType + " No.Of Engines:" + ((Motorboat)vehicle).NumberOfEngines + "\n");
                            break;
                        case "Ship":
                            Console.WriteLine(" Fuel Type: " + ((Ship)vehicle).FuelType + " No.Of Engines:" + ((Ship)vehicle).NumberOfEngines);
                            break;
                        case "Airoplane":
                            Console.WriteLine(" Fuel Type: " + ((Airoplane)vehicle).FuelType + " No.Of Engines:" + ((Airoplane)vehicle).NumberOfEngines + " Flight Altitude: " + ((Airoplane)vehicle).FlightAltitude + "\n");
                            break;
                        case "Bus":
                            Console.WriteLine(" No.Of Tyres: " + ((Bus)vehicle).NoOfTyres + " CylinderVolume: " + ((Bus)vehicle).CylinderVolume + " Fuel Type: " + ((Bus)vehicle).FuelType + "\n");
                            break;
                        case "Helicopter":
                            Console.WriteLine(" No.Of Tyres: " + ((Helicopter)vehicle).NoOfTyres + " Fuel Type: " + ((Helicopter)vehicle).FuelType + " No.Of Engines:" + ((Helicopter)vehicle).NumberOfEngines + " Flight Altitude: " + ((Helicopter)vehicle).FlightAltitude + "\n");
                            break;
                        case "Bicycle":
                            Console.WriteLine("\n");
                            break;
                        case "Boat":
                            Console.WriteLine("\n");
                            break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Slots Available: " + garage.Count);
            Console.WriteLine();
        }
    }
}
