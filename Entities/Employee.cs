using System.ComponentModel.DataAnnotations;

namespace CarRentEF.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; } = null!;
        [MaxLength(50)]
        public string PersonalNumber { get; set; } = null!;
        [MaxLength(50)]
        public string? Address { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; } = null!;
    }
}