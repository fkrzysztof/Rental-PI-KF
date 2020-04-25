using Rental.Data.Data.Areas.Identity.Data;
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

        [Display(Name = "Klient")]
        public string ApplicationUserID { get; set; }
            [ForeignKey("Id")]
            public ApplicationUser ApplicationUser { get; set; }

        // ************************************** from location

        [ForeignKey("RentalFromLocation")]
        public int? RentalFromLocationId { get; set; }
            [Display(Name = "Miejsce odbioru")]
            public RentalAgencyAddress RentalFromLocation { get; set; }

        // ************************************** to location

        [ForeignKey("RentalToLocation")]
        public int? RentalToLocationId { get; set; }
            [Display(Name = "Miejsce zwrotu")]
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

        
        [Display(Name = "Adnotacje")]
        public string Annotations { get; set; } 
        

        public bool IsActive { get; set; }

    }
}
