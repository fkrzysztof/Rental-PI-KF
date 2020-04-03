using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class Colour
    {
        [Key]
        public int ColourID { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Nazwa powinna zawierac od 3 do 15 znaków")]
        [Display(Name = "Kolor")]
        public string? Name { get; set; }
        
        [Display(Name = "Opis")]
        public string Description { get; set; }
        
        public bool IsActive { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
