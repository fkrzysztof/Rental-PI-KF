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

        public int BrandID { get; set; }
            //public virtual Brand Brand { get; set; }

        public int VehicleModelID { get; set; }
            //public virtual VehicleModel VehicleModel { get; set; }
        
        public DateTime? YearOfProduction { get; set; }

        public int RentalAgencyID { get; set; }
            //public virtual RentalAgency RentalAgency { get; set; }
        
        //pojemnosc silnika
        public int? EngineCapacity { get; set; }

        public int EquipmentID { get; set; }
            //public virtual Equipment Equipment { get; set; }
        
        public string Description { get; set; }

        public int GeneralTypeID { get; set; }
            //public GeneralType GeneralType { get; set; }

        public int ExactTypeID { get; set; }
            //public ExactType ExactType { get; set; }

        public int EngineTypeID { get; set; }
            //public EngineType EngineType { get; set; }
        
        public string Mileage { get; set; }

        public int ColourID { get; set; }
            //public Colour Colour { get; set; }
        
        public string VIN { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string NumberPlate { get; set; }
        
        //public virtual ICollection<Picture> Pictures { get; set; }
                
        public int? EnginePower { get; set; }

        public int GearBoxID { get; set; }
            //public GearBox GearBox { get; set; }

        public int WheelDriveID { get; set; }
            //public WheelDrive WheelDrive { get; set; }

        public byte? NumberOfSeats { get; set; }
        public byte? NumberOfDoors { get; set; }
        
        //public virtual ICollection<CurrentPrice> CurrentPrices { get; set; }
      
        public bool? IsActive { get; set; }
    }
}
