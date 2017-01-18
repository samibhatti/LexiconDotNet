using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GrageApplikation
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private int capacity;
        private int count;
        private string parkingSlotNo;
        private T[] vehicles;

        public string ParkingSlotNo { get { return parkingSlotNo; } set { parkingSlotNo = value; } }
        public int Capacity { get { return capacity; } set {capacity = value; } }
        public int Count { get; set; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            Count = Capacity;
            vehicles = new T[Count];
            ParkingSlotNo = parkingSlotNo;
        }

        public void parkVehicle(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    ParkingSlotNo = vehicle.VehicleTypeId + i;
                    vehicle.ParkingLotNo = ParkingSlotNo;
                    //vehicle.RegNr = autoRegNoGen();
                    vehicles[i] = vehicle;
                    Count -= 1;
                    break;
                }
            }
        }

        public void unparkVehicle(String name)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if ((vehicles[i] != null) && (vehicles[i].VehicleName.Equals(name, StringComparison.OrdinalIgnoreCase) ||
                    vehicles[i].RegNr.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    vehicles[i] = null;
                    Count += 1;
                }
            }
        }

        public T[] listParkedVehicle()
        {
            int count = 0;
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null)
                    count += 1;
            }

            T[] array = new T[count];

            int index = 0;

            foreach (T vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    array[index] = vehicle;
                    index += 1;
                }
            }
            return array;
        }

        public T[] listSpTypeVehicle(string type)
        {
            count = 0;
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null &&
                    (vehicle.VehicleTypeName.Equals(type, StringComparison.OrdinalIgnoreCase)))
                {
                    count += 1;
                }
            }

            var result = new T[count];
            int index = 0;
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null &&
                    (vehicle.VehicleTypeName.Equals(type, StringComparison.OrdinalIgnoreCase)))
                {
                    result[index] = vehicle;
                    index += 1;
                }
            }
            return result;
        }

        public T[] find(string name)
        {
            count = 0;
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null && 
                    (vehicle.VehicleName.Equals(name, StringComparison.OrdinalIgnoreCase) ||
                    //vehicle.FuelType.Equals(name, StringComparison.OrdinalIgnoreCase) || 
                    vehicle.RegNr.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    count += 1;
                }
            }

            var result = new T[count];
            int index = 0;
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null &&
                    (vehicle.VehicleName.Equals(name, StringComparison.OrdinalIgnoreCase) ||
                    //vehicle.FuelType.Equals(name, StringComparison.OrdinalIgnoreCase) ||
                    vehicle.RegNr.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    result[index] = vehicle;
                    index += 1;
                }
            }
            return result;
        }

        public string autoRegNoGen()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var num = "1234567890";
            Random random = new Random();
            var beta = new char[7];
            var bravo = new char[3];

            for (int i = 0; i < 3; i++)
            {
                char alpha = chars[random.Next(chars.Length)];
                char gamma = num[random.Next(num.Length)];

                beta[i] = alpha;
                bravo[i] = gamma;
                if (i > 1)
                {
                    bravo.CopyTo(beta, 3);
                    break;
                }
            }
            return new string(beta).TrimEnd('\0');
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    yield return vehicles[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }

}