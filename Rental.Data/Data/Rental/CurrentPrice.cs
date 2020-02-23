using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class CurrentPrice
    {
        [Key]
        public int CurrentPriceID { get; set; }

        public int? VehicleID { get; set; }
            [ForeignKey("VehicleID")]
            public Vehicle Vehicle { get; set;}

        [Display(Name = "Cena /24h")]
        public decimal? Price { get; set; }
        
        [Display(Name = "Wypożyczenie od")]
        public DateTime? DateTimeFrom { get; set; }
        
        [Display(Name = "Wypożyczenie do")]
        public DateTime? DateTimeTo { get; set; }
       
        public bool IsActive { get; set; }
    }
}
