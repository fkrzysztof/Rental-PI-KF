using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental.Data.Data.Rental
{
    public class RentalStatus
    {
        [Key]
        public int RentalStatusID { get; set; }
        
        [Display(Name = "Status")]
        public String Name { get; set; }
        
        public ICollection<RentalVehicle> RentalVehicle { get; set; }
        
        public bool IsActive { get; set; }
    }
}
