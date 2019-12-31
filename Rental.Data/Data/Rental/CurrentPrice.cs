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


        public int VehicleID { get; set; }
            public Vehicle Vehicle { get; set;}
        
        public decimal? Price { get; set; }
        public DateTime? DateTimeFrom { get; set; }
        public DateTime? DateTimeTo { get; set; }
        public bool IsActive { get; set; }
    }
}
