using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rental_Data.Data.CMS;
using Rental_Data.Data.Rental;

namespace Rental.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        //Strona
        public DbSet<Page> Pages { get; set; }
        public DbSet<News> News { get; set; }
        //Wypozyczalnia
        public DbSet<ExactType> ExactTypes { get; set; }
        public DbSet<AirConditioning> AirConditionings { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<RentalAgency> RentalAgencies { get; set; }
        public DbSet<RentalAgencyAddress> RentalAgencyAddresses { get; set; }
        public DbSet<GeneralType> GeneralTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<CurrentPrice> CurrentPrices { get; set; }
        public DbSet<WheelDrive> WheelDrives { get; set; }
        public DbSet<GearBox> GearBoxes { get; set; }
    }
}
