using Rental_Data.Data.Rental;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental.Data.Data.Rental
{
    public class EquipmentName
    {
        [Key]
        public int EquipmentNameID { get; set; }

        public string Name { get; set; }

        public ICollection<Equipment> Equipment { get; set; }
        
        public bool IsActive { get; set; }
    }
}
