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
        public bool ABS { get; set; }
        public bool AUX { get; set; }
        public bool ISOFIX { get; set; }
        public bool CD { get; set; }
        public bool SD { get; set; }
        public bool USB { get; set; }
        
        [Display(Name = "Tempomat")]
        public bool CruiseControl { get; set; }

        [Display(Name = "Nawigacja")]
        public bool Navigation { get; set; }

        public bool Airbag { get; set; }

        [Display(Name = "Wspomaganie kierownicy")]
        public bool PowerSteering { get; set; }

        [Display(Name = "Klimatyzacja")]
        public int? AirConditioningID { get; set; }
            public AirConditioning AirConditioning { get; set; }
        
        public Vehicle Vehicle { get; set; }

        public bool IsActive { get; set; }
    }
}
