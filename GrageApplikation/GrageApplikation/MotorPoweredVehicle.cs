namespace GrageApplikation
{
    abstract class MotorPoweredVehicle : LandVehicle
    {
        public int numberOfEngines;
        public int cylinderVolume;
        public string fuelType;
        
        public MotorPoweredVehicle()
        {
        }
    }
}