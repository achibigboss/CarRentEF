using System.ComponentModel.DataAnnotations;

namespace CarRentEF.Entities
{
    public class Driver
    {
        public int DriverId { get; set; }
        [MaxLength(15)]
        public string LicenseNumber { get; set; } = null!;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
    }
}