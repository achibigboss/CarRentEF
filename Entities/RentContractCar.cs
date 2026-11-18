namespace CarRentEF.Entities
{
    public class RentContractCar
    {
        public int RentContractId { get; set; }
        public RentContract RentContract { get; set; } = null!;

        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        public int? DriverId { get; set; }
        public Driver? Driver { get; set; } = null!;
    }
}