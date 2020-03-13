using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rental.Data.Data.Rental
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
    }
}
