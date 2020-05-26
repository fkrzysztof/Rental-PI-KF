using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;

namespace Rental.WWW.Controllers.Abstract
{
    //[Authorize(Roles = "Administrator,Pracownik")]
    //[Authorize]
    public class BasicAbstractController : Controller
    {
        protected readonly UserManager<ApplicationUser> _userManager;
        protected readonly ApplicationDbContext _context;

        public BasicAbstractController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public ApplicationUser GetUser()
        {
            if (User.Identity.IsAuthenticated)
                return _userManager.FindByNameAsync(User.Identity.Name).Result;
            else
                return null;
        }

        public string GetUserRoleName()
        {
            if (User.Identity.IsAuthenticated)
                return _userManager.GetRolesAsync(GetUser()).Result.First();
            else
                return null;
        }

    }
}


