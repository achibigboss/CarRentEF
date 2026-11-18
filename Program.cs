using System.Collections.Generic;
using System.Reflection.Emit;

namespace CarRentEF
{
    internal class Program
    {
        public const string ConnectionString = "Server=DESKTOP-RA14EMS\\SQLSERVER;Database=G12_CarRentalCenter_EntityFrameWork;Trusted_Connection=True;TrustServerCertificate=True";

        static void Main()
        {
            using var context = new CarRentDbContext();
            context.Database.EnsureCreated();
        }
    }
}