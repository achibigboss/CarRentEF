using CarRentEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRentEF
{
    public class CarRentDbContext : DbContext
    {
        public DbSet<Manufactur> Manufactures { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<CarClass> CarClass { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarTechnician> CarTechnician { get; set; }
        public DbSet<Technician> Technician { get; set; }
        public DbSet<Administrator> Administration { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<RentContract> RentContract { get; set; }
        public DbSet<RentContractCar> RentContractCar { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Program.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentContractCar>().HasKey(x => new { x.RentContractId, x.CarId });
            modelBuilder.Entity<CarTechnician>().HasKey(x => new { x.CarId, x.TechnicianId });

            modelBuilder.Entity<Administrator>().HasIndex(x => x.EmployeeId).IsUnique();
            modelBuilder.Entity<Technician>().HasIndex(x => x.EmployeeId).IsUnique();
            modelBuilder.Entity<Driver>().HasIndex(x => x.EmployeeId).IsUnique();
            modelBuilder.Entity<Car>().HasIndex(x => x.StateNumber).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(x => x.ClientIdCard).IsUnique();
            modelBuilder.Entity<Driver>().HasIndex(x => x.LicenseNumber).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(x => x.PersonalNumber).IsUnique();
        }
    }
}