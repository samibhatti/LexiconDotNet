namespace GrageApplikation
{
    class Motorboat : WaterVehicle
    {
            public string VehicleName { get { return vehicleName; } set { vehicleName = value; } }
            public string VehicleType { get { return vehicleType; } set { vehicleType = value; } }
            public Motorboat(string name)
            {
                VehicleName = name;
                VehicleType = "Motorboat";
                vT = "E";
        }
    }
}