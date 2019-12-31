using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class VehicleModel
    {
        [Key]
        public int VehicleModelID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    
        public ICollection<Vehicle> Vehicles { get; set; }
        //public virtual Brand Brand { get; set; }


    
    }
}
