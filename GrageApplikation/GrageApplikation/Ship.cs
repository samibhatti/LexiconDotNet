namespace GrageApplikation
{
    internal class Ship : WaterVehicle
    {
        public string VehicleName { get { return vehicleName; } set { vehicleName = value; } }
        public string VehicleType { get { return vehicleType; } set { vehicleType = value; } }
        public Ship(string name)
        {
            VehicleName = name;
            VehicleType = "Ship";
            vT = "F";
        }
    }
}