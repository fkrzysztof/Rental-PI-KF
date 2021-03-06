﻿using Rental.Data.Data.Areas.Identity.Data;
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


        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Pole powinno zawierać od 3 do 20 znaków")]
        [Display(Name = "Kontakt")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Pole powinno zawierać od 3 do 20 znaków")]
        [Display(Name = "Numer")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Oddział firmy")]
        public bool BranchOfCompany { get; set;}

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Pole powinno zawierać od 3 do 20 znaków")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Telefon 1")]
        public string Phone1 { get; set; }

        [Display(Name = "Telefon 2")]
        public string Phone2 { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [EmailAddress]
        [Display(Name = "Email 1")]
        public string Email1 { get; set; }

        [EmailAddress]
        [Display(Name = "Email 2")]
        public string Email2 { get; set; }

        [Display(Name = "Data dodania")]
        [Column(TypeName = "Date")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Opis")]
        public string Annotation { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
        
        public RentalAgencyAddress RentalAgencyAddress { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        public string REGON { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        public string NIP { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; }

    }
}
