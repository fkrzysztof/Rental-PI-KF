using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental_Data.Data.Rental
{ 
    public class WheelDrive //naped
    {
        [Key]
        public int WheelDriveID { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Nazwa powinna zawierac od 3 do 10 znaków")]
        [Display(Name = "Napęd")]
        public string? Name { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
