using Microsoft.AspNetCore.Identity;
using Rental.Data.Data.Rental;
using Rental_Data.Data.Rental;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rental.Data.Data.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Nazwa powinna zawierac od 3 do 20 znaków")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Nazwa powinna zawierac od 3 do 20 znaków")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Imie i Nazwisko")]
        public string Fullname { get { return this.FirstName + " " + this.LastName + "  / " + this.Email; } }

        [Display(Name = "Zdjęcie")]
        public byte[] Image { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Nazwa powinna zawierac od 3 do 20 znaków")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Nazwa powinna zawierac od 3 do 20 znaków")]
        [Display(Name = "Kraj")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Nazwa powinna zawierac od 3 do 20 znaków")]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Numer")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Kod")]
        public string ZIPCode { get; set; }

        [Display(Name = "Oddział")]
        public int? RentalAgencyID { get; set; }
        [Display(Name = "Oddział")]
        [ForeignKey("RentalAgencyID")]
        RentalAgency RentalAgency { get; set; }

        public ICollection<RentalVehicle> RentalVehicles { get; set; }
    }
}
