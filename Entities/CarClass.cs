using System.ComponentModel.DataAnnotations;

namespace CarRentEF.Entities
{
    public class CarClass
    {
        public int CarClassId { get; set; }
        [MaxLength(50)]
        public string ClassName { get; set; } = null!;
    }
}