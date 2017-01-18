namespace GrageApplikation
{
    abstract class Vehicle
    {
       
        public virtual string RegNr { get; set; }
        public virtual string VehicleName { get; set; }
        public virtual string VehicleTypeName { get; set; }
        public virtual string VehicleTypeId { get; set; }
        public virtual string Color { get; set; }
        public virtual string ParkingLotNo { get; set; }
        public virtual int VehicleLength { get; set; }
        public virtual int NumberOfSeats { get; set; }
             
        public Vehicle()
        {
        }
    }
}