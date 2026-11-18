using System.ComponentModel.DataAnnotations;

namespace CarRentEF.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; } = null!;
        [MaxLength(50)]
        public string ClientIdCard { get; set; } = null!;
        [MaxLength(15)]
        public string Phone { get; set; } = null!;
    }
}