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
        
        public int? BrandID { get; set; }
            [ForeignKey("BrandID")]
            public Brand Brand { get; set; }
        
        public int? VehicleModelID { get; set; }
            [ForeignKey("VehicleModelID")]
            public VehicleModel VehicleModel { get; set; }
        
        [Column(TypeName = "Date")]
        public DateTime? YearOfProduction { get; set; }
        
        public int? RentalAgencyID { get; set; }
            [ForeignKey("RentalAgencyID")]
            public RentalAgency RentalAgency { get; set; }
        
        //pojemnosc silnika
        public int? EngineCapacity { get; set; }
        //relacja jeden do jeden!!
        
        public int? EquipmentID { get; set; }
            [ForeignKey("EquipmentID")]
            public Equipment Equipment { get; set; }
        
        public string Description { get; set; }

        public int? GeneralTypeID { get; set; }
            [ForeignKey("GeneralTypeID")]
            public GeneralType GeneralType { get; set; }

        public int? ExactTypeID { get; set; }
            [ForeignKey("ExactTypeID")]
            public ExactType ExactType { get; set; }

        public int? EngineTypeID { get; set; }
            [ForeignKey("EngineTypeID")]
            public EngineType EngineType { get; set; }

        public string Mileage { get; set; }

        public int? ColourID { get; set; }
            [ForeignKey("ColourID")]
            public Colour Colour { get; set; }

        public string VIN { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string NumberPlate { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public int? EnginePower { get; set; }
        
        public int? GearBoxID { get; set; }
            [ForeignKey("GearBoxID")]
            public GearBox GearBox { get; set; }

        //naped
        public int? WheelDriveID { get; set; }
            [ForeignKey("WheelDriveID")]
            public WheelDrive WheelDrive { get; set; }

        public byte? NumberOfSeats { get; set; }
        public byte? NumberOfDoors { get; set; }
        //cena (zmiany ceny)
        public ICollection<CurrentPrice> CurrentPrices { get; set; }
      
        public bool IsActive { get; set; }
    }
}
