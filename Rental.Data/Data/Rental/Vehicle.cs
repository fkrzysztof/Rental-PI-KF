﻿using Rental.Data.Data.Rental;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rental_Data.Data.Rental
{
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }

        //[Required]
        [Display(Name = "Zdjęcie")]
        public byte[]? Image { get; set; }

        [Display(Name = "Marka")]
        [Required]
        public int BrandID { get; set; }
        [Display(Name = "Marka")]
        [ForeignKey("BrandID")]
        public Brand Brand { get; set; }

        [Display(Name = "Model")]
        [Required]
        public int VehicleModelID { get; set; }
        [Display(Name = "Model")]
        [ForeignKey("VehicleModelID")]
        public VehicleModel VehicleModel { get; set; }

        [Display(Name = "Rocznik")]
        public int YearOfCarProduction { get; set; }

        [Display(Name = "Wypożyczalnia")]
        public int? RentalAgencyID { get; set; }
        [Display(Name = "Wypożyczalnia")]
        [ForeignKey("RentalAgencyID")]
        public RentalAgency RentalAgency { get; set; }

        [Display(Name = "Pojemność")]
        public int? EngineCapacity { get; set; }

        [Display(Name = "Wyposażenie")]
        public ICollection<Equipment> Equipment { get; set; }

        [Display(Name = "Klimatyzacja")]
        public int? AirConditioningID { get; set; }
        [Display(Name = "Klimatyzacja")]
        [ForeignKey("AirConditioningID")]
        public AirConditioning AirConditioning { get; set; }


        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Display(Name = "Typ")]
        public int? GeneralTypeID { get; set; }
        [Display(Name = "Typ")]
        [ForeignKey("GeneralTypeID")]
        public GeneralType GeneralType { get; set; }

        [Display(Name = "Rodzaj")]
        public int? ExactTypeID { get; set; }
        [Display(Name = "Rodzaj")]
        [ForeignKey("ExactTypeID")]
        public ExactType ExactType { get; set; }

        [Display(Name = "Silnik")]
        public int? EngineTypeID { get; set; }
        [Display(Name = "Silnik")]
        [ForeignKey("EngineTypeID")]
        public EngineType EngineType { get; set; }

        [Display(Name = "Przebieg")]
        public string Mileage { get; set; }

        [Display(Name = "Kolor")]
        public int? ColourID { get; set; }
        [Display(Name = "Kolor")]
        [ForeignKey("ColourID")]
        public Colour Colour { get; set; }

        public string VIN { get; set; }

        [Display(Name = "W ofercie od")]
        public DateTime? DateIn { get; set; }

        [Display(Name = "W ofercie do")]
        public DateTime? DateOut { get; set; }

        [Display(Name = "Nr Rej.")]
        public string NumberPlate { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }

        [Display(Name = "Moc (KM)")]
        public int? EnginePower { get; set; }

        [Display(Name = "Skrzynia")]
        public int? GearBoxID { get; set; }
        [Display(Name = "Skrzynia")]
        [ForeignKey("GearBoxID")]
        public GearBox GearBox { get; set; }

        [Display(Name = "Napęd")] 
        public int? WheelDriveID { get; set; }
        [Display(Name = "Napęd")]
        [ForeignKey("WheelDriveID")]
        public WheelDrive WheelDrive { get; set; }

        [Display(Name = "Ilość miejsc")]
        public byte? NumberOfSeats { get; set; }

        [Display(Name = "Ilość drzwi")]
        public byte? NumberOfDoors { get; set; }
        //cena (zmiany ceny)
        public ICollection<CurrentPrice> CurrentPrices { get; set; }

        public ICollection<RentalVehicle> RentalVehicles { get; set; }

        [Display(Name = "Zablokowany")]
        public bool? Blockade { get; set; }

        [NotMapped]
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
