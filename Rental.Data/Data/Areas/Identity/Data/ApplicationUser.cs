using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rental.Data.Data.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string CustomTag { get; set; }
    }
}
