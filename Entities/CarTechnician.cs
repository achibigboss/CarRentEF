namespace CarRentEF.Entities
{
    public class CarTechnician
    {
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;
        public int TechnicianId { get; set; }
        public Technician Technician { get; set; } = null!;
    }
}