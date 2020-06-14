using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class VehicleModel
    {
        [Key]
        public int VehicleModelID { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Model")]
        public string Name { get; set; }
        
        public bool IsActive { get; set; }
        
        public int? BrandID { get; set; }
        [ForeignKey("BrandID")]
        public Brand Brand { get; set; }
        
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
