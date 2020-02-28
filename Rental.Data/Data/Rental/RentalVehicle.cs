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
