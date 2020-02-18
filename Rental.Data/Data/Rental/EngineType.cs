using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental_Data.Data.Rental
{
    public class EngineType
    {
        [Key]
        public int EngineTypeID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
