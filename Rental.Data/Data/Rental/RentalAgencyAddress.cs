using Rental.Data.Data.Rental;
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

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Pole powinno zawierać od 3 do 20 znaków")]
        [Display(Name = "Kraj")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Pole powinno zawierać od 3 do 20 znaków")]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Pole powinno zawierać od 3 do 20 znaków")]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Numer")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Kod")]
        public string ZIPCode { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        public bool IsActive { get; set; }

        public int? RentalAgencyID { get; set; }
        [ForeignKey("RentalAgencyID")]
        public RentalAgency RentalAgency { get; set; }


        //potrzebne do wybierania miejsca wypozyczenia i zdania pojazdu

        [InverseProperty("RentalFromLocation")]
        public ICollection<RentalVehicle> FromRentalVehicles { get; set; }
        
        [InverseProperty("RentalToLocation")]
        public ICollection<RentalVehicle> ToRentalVehicles { get; set; }

    }
}
