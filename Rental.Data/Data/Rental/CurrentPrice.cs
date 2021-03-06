﻿using System;
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
        
        [Column(TypeName = "money")]
        [Display(Name = "Cena / 24h")]
        public decimal? PriceDay { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Cena / Weekend+")]
        public decimal? PriceWeekend { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Cena / 7+ dni")]
        public decimal? PriceWeek { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Cena / 14+ dni")]
        public decimal? PriceLong { get; set; }
        
        [Display(Name = "Wypożyczenie od")]
        public DateTime? DateTimeFrom { get; set; }
        
        public bool IsActive { get; set; }
    }
}
