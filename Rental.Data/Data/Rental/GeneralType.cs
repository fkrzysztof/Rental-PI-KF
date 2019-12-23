using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class GeneralType
    {
        [Key]
        public int GeneralTypeID { get; set; }

        //public virtual ICollection<ExactType> ExactTypes { get; set; }

        public string Name { get; set; }
        public bool? IsActive { get; set; }

        //public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
