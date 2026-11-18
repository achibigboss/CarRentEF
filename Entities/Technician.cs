using System.ComponentModel.DataAnnotations;

namespace CarRentEF.Entities
{
    public class Technician
    {
        public int TechnicianId { get; set; }
        [MaxLength(50)]
        public string Qualification { get; set; } = null!;
        public int ExperienceYears { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
    }
}