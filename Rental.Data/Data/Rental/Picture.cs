using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class Picture
    {
        [Key]
        public int PictureID { get; set; }
        
        public int? VehicleID { get; set; }
        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { get; set; }
        
        public string URL { get; set; }
        public bool IsActive { get; set; }
    }
}
