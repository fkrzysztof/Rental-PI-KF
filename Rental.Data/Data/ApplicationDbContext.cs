using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.Data.Data.Rental;
using Rental_Data.Data.Rental;

namespace Rental.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>//dopisane
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //dopisane
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }



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
        public DbSet<EquipmentName> EquipmentNames { get; set; }
        public DbSet<RentalVehicle> RentalVehicles { get; set; }
        public DbSet<RentalStatus> RentalStatuses { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ReadMessages> ReadMessages { get; set; }
        public DbSet<News> News { get; set; }

    }
}
