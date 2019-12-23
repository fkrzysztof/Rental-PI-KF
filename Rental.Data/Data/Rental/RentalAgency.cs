using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class RentalAgency
    {
        [Key]
        public int RentalAgencyID { get; set; }

        //public virtual RentalAgencyAddress RentalAgencyAddress { get; set; }
        
        public string ContactPerson { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Annotation { get; set; }
        public bool? IsActive { get; set; }

        //public virtual ICollection<Vehicle> Vehicles { get; set; }

        //mozna dodac regony itd.

    }
}
