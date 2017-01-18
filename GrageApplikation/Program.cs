using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace GrageApplikation
{
    class Program
    {

        static void Main(string[] args)
        {
            int capacity = 0;

            Console.Write("\nEnter Garage Capacity to create a garage: ");
            string capacityInput = Console.ReadLine();
            capacity = inputValidationCheckInt(capacityInput);

            var manager = new GarageManager(capacity);

            bool quit = true;
            do
            {
                Console.WriteLine();
                Console.Write(" Select Option OR Enter Q to Quit:\n P to Park \n U to Unpark \n L to List All \n T to List Vehicles of specific Type \n S to Search \n Enter option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "p":
                    case "P":
                        selectVehicleType(manager);
                        break;
                    case "s":
                    case "S":
                        Console.Write(" Enter Vehicle Reg.No. , Name OR Fuel Type: ");
                        string item = Console.ReadLine();
                        manager.findVehicle(item);
                        break;
                    case "l":
                    case "L":
                        manager.listParkedVehicle();
                        break;
                    case "t":
                    case "T":
                        Array array = new string[8] { "Car", "Buss", "Motorcycle", "Motorboat", "Boat", "Ship", "Airoplane", "Helicopter" };
                        manager.listSpecificTypeParkedVehicle(array);
                        break;
                    case "q":
                    case "Q":
                        quit = false;
                        break;
                    case "u":
                    case "U":
                        Console.Write("Enter Vehicle Reg.No. OR Name to Unpark: ");
                        string name = Console.ReadLine();
                        manager.unParkVehicle(name);
                        break;
                    default:
                        break;
                }
            } while (quit);
        }

        public static void selectVehicleType(GarageManager manager)
        {
            bool quit = true;
            do
            {
                Console.WriteLine();
                Console.Write(" A Park a Car \n"
                            + " B Park a Motorcycle \n"
                            + " C Park a Motorboat \n"
                            + " D Park a Ship \n"
                            + " E Park a Cycle \n"
                            + " F Park a Airoplane \n"
                            + " G Park a Bus \n"
                            + " H Park a Boat \n"
                            + " I Park a Helicopter \n"
                            + " Enter vehicle type OR Enter Q to quit: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "a":
                    case "A":
                        userInput(manager, new Car());
                        break;
                    case "b":
                    case "B":
                        userInput(manager, new Motorcycle());
                        break;
                    case "c":
                    case "C":
                        userInput(manager, new Motorboat());
                        break;
                    case "d":
                    case "D":
                        userInput(manager, new Ship());
                        break;
                    case "e":
                    case "E":
                        userInput(manager, new Bicycle());
                        break;
                    case "f":
                    case "F":
                        userInput(manager, new Airoplane());
                        break;
                    case "g":
                    case "G":
                        userInput(manager, new Bus());
                        break;
                    case "h":
                    case "H":
                        userInput(manager, new Boat());
                        break;
                    case "i":
                    case "I":
                        userInput(manager, new Helicopter());
                        break;
                    case "q":
                    case "Q":
                        quit = false;
                        break;
                    default:
                        break;
                }
            } while (quit);
        }

        public static void userInput(GarageManager manager, Vehicle vehicle)
        {
            string name;
            string regNr;
            string color;
            string fuel = "nil";
            int seats;
            int length;
            int tyres = 0;
            int cc = 0;
            int engines = 0;
            int thrust = 0;
            int altitude = 0;
            bool output;
            bool loop = true;

            do
            {

                Console.Write("Enter Vehicle's Name: ");
                name = Console.ReadLine();
                output = inputValidationCheckString(name);
                if (output == true) { break; }

                Console.Write("\nEnter Vehicle's Reg.No.: ");
                regNr = Console.ReadLine();
                output = inputValidationCheckString(regNr);
                if (output == true) { break; }

                Console.Write("\nEnter Vehicle's Color: ");
                color = Console.ReadLine();
                output = inputValidationCheckString(color);
                if (output == true) { break; }

                Console.Write("\nEnter Vehicle's No. of Seats: ");
                string seatInput = Console.ReadLine();
                seats = inputValidationCheckInt(seatInput);
                if (seats == 0) { break; }

                Console.Write("\nEnter Vehicle's length(cm): ");
                string lengthInput = Console.ReadLine();
                length = inputValidationCheckInt(lengthInput);
                if (length == 0) { break; }

                if (vehicle.VehicleTypeName == "Bicycle")
                {
                    Console.Write("\nEnter Vehicle's No. of Tyres: ");
                    string tyresInput = Console.ReadLine();
                    tyres = inputValidationCheckInt(tyresInput);
                    if (tyres == 0) { break; }
                }

                if (vehicle.VehicleTypeName == "Car" || vehicle.VehicleTypeName == "Motorcycle" || vehicle.VehicleTypeName == "Bus")
                {
                    Console.WriteLine("vehicle type " + vehicle.VehicleTypeName);

                    Console.Write("\nEnter Vehicle's Engine Capacity(CC): ");
                    string ccInput = Console.ReadLine();
                    cc = inputValidationCheckInt(ccInput);
                    if (cc == 0) { break; }

                    Console.Write("\nEnter Vehicle's Fuel-Type(Petrol/Diesel/Jetfuel): ");
                    fuel = Console.ReadLine();
                    output = inputValidationCheckString(fuel);
                    if (output == true) { break; }

                    Console.Write("\nEnter Vehicle's No. of Tyres: ");
                    string tyresInput = Console.ReadLine();
                    tyres = inputValidationCheckInt(tyresInput);
                    if (tyres == 0) { break; }
                }

                if (vehicle.VehicleTypeName == "Airoplane" || vehicle.VehicleTypeName == "Helicopter")
                {
                    Console.Write("\nEnter Vehicle's Fuel-Type(Petrol/Diesel/Jetfuel): ");
                    fuel = Console.ReadLine();
                    output = inputValidationCheckString(fuel);
                    if (output == true) { break; }

                    Console.Write("\nEnter Vehicle's No. of Engines: ");
                    string enginesInput = Console.ReadLine();
                    engines = inputValidationCheckInt(enginesInput);
                    if (engines == 0) { break; }

                    Console.Write("\nEnter Vehicle's No. of Tyres: ");
                    string tyresInput = Console.ReadLine();
                    tyres = inputValidationCheckInt(tyresInput);
                    if (tyres == 0) { break; }


                    Console.Write("\nEnter Vehicle's Total Thrust(Pounds): ");
                    string thrustInput = Console.ReadLine();
                    thrust = inputValidationCheckInt(thrustInput);
                    if (thrust == 0) { break; }

                    Console.Write("\nEnter Vehicle's Flight Altitude(Feet): ");
                    string altitudeInput = Console.ReadLine();
                    altitude = inputValidationCheckInt(altitudeInput);
                    if (altitude == 0) { break; }
                }

                manager.parkVehicle(vehicle, name.ToUpper(), regNr.ToUpper(), color.ToUpper(), length, seats, tyres, cc, fuel.ToUpper(), engines, thrust, altitude);
                loop = false;
            } while (loop);
        }

        static int inputValidationCheckInt(string input)
        {
            int output;
            if (int.TryParse(input, out output))
            {
                if (output < 0)
                {
                    output = 0;
                    Console.WriteLine("Value must be greater than 0");
                }
                //Console.WriteLine("ok" + seats);
            }
            else
            {
                Console.WriteLine("Invalid input re-try!");
                output = 0;
            }

            return output;
        }

        static bool inputValidationCheckString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input re-try!");
                return true;
            }

            return false;
        }
    }
}
