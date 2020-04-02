using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class GeneralType
    {
        [Key]
        public int GeneralTypeID { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Nazwa powinna zawierac od 3 do 10 znaków")]
        [Display(Name = "Typ")]
        public string? Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

        public ICollection<ExactType> ExactTypes { get; set; }
    }
}
