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
        public bool? ABS { get; set; }
        public bool? AUX { get; set; }
        public bool? ISOFIX { get; set; }
        public bool? CD { get; set; }
        public bool? SD { get; set; }
        public bool? USB { get; set; }
        public bool? CruiseControl { get; set; }
        public bool? Navigation { get; set; }
        public bool? Airbag { get; set; }
        public bool? PowerSteering { get; set; }

        public int AirConditioningID { get; set; }
            public AirConditioning AirConditioning { get; set; }
        
        public int VehicleID { get; set; }
            public Vehicle Vehicle { get; set; }

        public bool? IsActive { get; set; }
    }
}
