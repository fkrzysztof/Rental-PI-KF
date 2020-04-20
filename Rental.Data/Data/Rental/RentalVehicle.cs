using Rental_Data.Data.Rental;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rental.Data.Data.Rental
{
    public class RentalVehicle
    {
        [Key]
        public int RentalVehicleID { get; set; }

        [Display(Name = "Pojazd")]
        public int VehicleID { get; set; }
            [ForeignKey("VehicleID")]
            public Vehicle Vehicle { get; set; }

        // ************************************** from location
        [Display(Name = "Miejsce odbioru")]
        [ForeignKey("RentalFromLocation")]
        public int? RentalFromLocationId { get; set; }
        public RentalAgencyAddress RentalFromLocation { get; set; }

        // ************************************** to location
        [Display(Name = "Miejsce zwrotu")]
        [ForeignKey("RentalToLocation")]
        public int? RentalToLocationId { get; set; }
        public RentalAgencyAddress RentalToLocation { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Od")]
        public DateTime From { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Do")]
        public DateTime To { get; set; }
    
        public int RentalStatusID { get; set; }
            [ForeignKey("RentalStatusID")]
            public RentalStatus RentalStatus { get; set; }

        [Display(Name = "Data utworzenia")]
        public DateTime CreationDate { get; set; } 

        public bool IsActive { get; set; }

    }
}
