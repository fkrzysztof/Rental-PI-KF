using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class RentalAgencyAddress
    {
        [Key]
        public int RentalAgencyAddressID { get; set; }

        [Display(Name = "Kraj")]
        public string Country { get; set; }

        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Display(Name = "Ulica")]
        public string Street { get; set; }
        
        [Display(Name = "Numer")]
        public string Number { get; set; }

        [Display(Name = "Kod")]
        public string ZIPCode { get; set; }

        public bool IsActive { get; set; }

        public int? RentalAgencyID { get; set; }
        [ForeignKey("RentalAgencyID")]
        public RentalAgency RentalAgency { get; set; }
    }
}
