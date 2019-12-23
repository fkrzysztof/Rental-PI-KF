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
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }

        //public virtual ICollection<Vehicle> Vehicles {get; set;}
    }
}
