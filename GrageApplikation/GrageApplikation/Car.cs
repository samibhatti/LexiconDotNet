namespace GrageApplikation
{
    internal class Car : MotorPoweredVehicle
    {
        public string VehicleName { get {return vehicleName; } set {vehicleName = value; } }
        public string VehicleType { get { return vehicleType; } set { vehicleType = value; } }

        public Car(string name)
        {
            VehicleName = name;
            VehicleType = "Car";
            vT = "A";
                         
        }
    }
}