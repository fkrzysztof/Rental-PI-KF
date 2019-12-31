using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class ExactType
    {
        [Key]
        public int ExactTypeID { get; set; }

        //public int GeneralTypeID { get; set; }
          //  public GeneralType GeneralType { get; set; }

        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
