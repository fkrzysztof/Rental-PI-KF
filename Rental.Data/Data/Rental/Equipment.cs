using Rental.Data.Data.Rental;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class Equipment
    {
        [Key]
        public int EquipmentID { get; set; }

        public int? VehicleID { get; set; }
            [ForeignKey("VehicleID")]
            public Vehicle Vehicle { get; set; }

        public int? EquipmentNameID { get; set; }
            [ForeignKey("EquipmentNameID")]
            public EquipmentName EquipmentName { get; set; }

        public bool Check { get; set; }

        public bool IsActive { get; set; }
    }
}
