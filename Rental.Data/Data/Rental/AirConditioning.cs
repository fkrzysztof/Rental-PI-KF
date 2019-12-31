using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class AirConditioning
    {
        [Key]
        public int AirConditioningID { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Equipment> Equipment { get; set; }
    }
}
