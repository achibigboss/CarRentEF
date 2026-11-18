using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentEF.Entities
{
    public class RentContract
    {
        public int RentContractId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public int RentalDurationDays { get; set; }
        [Column("TotalPrice", TypeName = "Money")]
        public decimal TotalPrice { get; set; }
    }
}