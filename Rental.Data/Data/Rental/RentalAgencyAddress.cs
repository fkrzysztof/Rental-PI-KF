using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class RentalAgencyAddress
    {
        [Key]
        public int RentalAgencyAddressID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZIPCode { get; set; }
        public bool? IsActive { get; set; }

        public int RentalAgencyID { get; set; }
            //public virtual RentalAgency RentalAgency { get; set; }
    }
}
