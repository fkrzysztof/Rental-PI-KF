using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class Brand
    {
        [Key]

        public int BrandID { get; set; }
        
        //public virtual ICollection<VehicleModel> VehicleModel { get; set; }
        //public virtual ICollection<Vehicle> Vehicles { get; set; }
        
        public string Name { get; set; }
        public bool? IsActive { get; set; }

    }
}
