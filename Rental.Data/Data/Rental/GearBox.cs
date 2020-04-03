using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class GearBox
    {
        [Key]
        public int GearBoxID { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Skrzynia biegów")]
        public string? Name { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }
        
        public bool IsActive { get; set; }

        public ICollection<Vehicle> Vehicles {get; set;}
    }
}
