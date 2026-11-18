using System.ComponentModel.DataAnnotations;

namespace CarRentEF.Entities
{
    public class Model
    {
        public int ModelId { get; set; }
        [MaxLength(100)]
        public string ModelName { get; set; } = null!;
        [MaxLength(500)]
        public string? Description { get; set; }
        public int ManufacturesId { get; set; }
        public Manufactur Manufactures { get; set; } = null!;
        public int CarClassId { get; set; }
        public CarClass CarClass { get; set; } = null!;
    }
}