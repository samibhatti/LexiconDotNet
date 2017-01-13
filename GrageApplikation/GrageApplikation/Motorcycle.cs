namespace GrageApplikation
{
    internal class Motorcycle : MotorPoweredVehicle
    {
        
        public string VehicleName { get { return vehicleName; } set { vehicleName = value; } }
        public string VehicleType { get { return vehicleType; } set { vehicleType = value; } }

        public Motorcycle(string name)
        {
            VehicleName = name;
            VehicleType = "Motorcycle";
            vT = "B";
        }
    }
}