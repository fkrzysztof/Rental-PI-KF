using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rental.Data.Data.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Imie i Nazwisko")]
        public string? Fullname { get { return this.FirstName + " " + this.LastName + "  / " + this.Email; } }

        [Display(Name = "Zdjęcie")]
        public byte[] Image { get; set; }

        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Display(Name = "Kraj")]
        public string Country { get; set; }
        
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Display(Name = "Numer")]
        public string? Number { get; set; }

        [Display(Name = "Kod")]
        public string? ZIPCode { get; set; }

    }
}
