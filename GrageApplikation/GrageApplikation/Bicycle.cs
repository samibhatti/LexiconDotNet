namespace GrageApplikation
{
    internal class Bicycle : HumanPoweredVehicle
    {
        public string VehicleName { get { return vehicleName; } set { vehicleName = value; } }
        public string VehicleType { get { return vehicleType; } set { vehicleType = value; } }
        public Bicycle(string name)
        {
            VehicleName = name;
            VehicleType = "Bicycle";
            vT = "D";
        }
    }
}