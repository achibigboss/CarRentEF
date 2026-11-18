using System.ComponentModel.DataAnnotations;

namespace CarRentEF.Entities
{
    public class Manufactur
    {
        public int ManufacturesId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}