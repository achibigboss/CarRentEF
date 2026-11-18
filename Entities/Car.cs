using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentEF.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        [MaxLength(50)]
        public string? Color { get; set; }
        [Column("RentPrice", TypeName = "Money")]
        public decimal RentPrice { get; set; }
        [MaxLength(11)]
        public string StateNumber { get; set; } = null!;
        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;
    }
}