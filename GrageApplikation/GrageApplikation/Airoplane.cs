namespace GrageApplikation
{
    class Airoplane : AirVehicle
    {
        public string VehicleName { get { return vehicleName; } set { vehicleName = value; } }
        public string VehicleType { get { return vehicleType; } set { vehicleType = value; } }

        public Airoplane(string name)
        {
            VehicleName = name;
            VehicleType = "Airoplane";
            vT = "C";
        }
    }
}