using System.ComponentModel.DataAnnotations;

namespace CarRentEF.Entities
{
    public class Administrator
    {
        public int AdministrationId { get; set; }
        [MaxLength(50)]
        public string Position { get; set; } = null!;
        [MaxLength(50)]
        public string Education { get; set; } = null!;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
    }
}