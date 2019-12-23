using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Data
{
    public class TableTest
    {
        [Key]
        public int TableTestID { get; set; }
        public string Name { get; set; }
    }
}
