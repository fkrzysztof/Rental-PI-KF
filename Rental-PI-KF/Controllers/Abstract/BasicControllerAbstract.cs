using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_PI_KF.Controllers.Abstract
{
    public class BasicControllerAbstract : Controller
    {



        protected readonly UserManager<ApplicationUser> _userManager;
        protected readonly ApplicationDbContext _context;
        public ApplicationUser user;
        public BasicControllerAbstract(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
          _userManager = userManager;
          _context = context;

            

        }
        public void UserProfile()
        {
            var id = _userManager.GetUserId(HttpContext.User);
            var us = _userManager.Users;
            user = us.FirstOrDefault(f => f.Id == id);
            user.PasswordHash = null;
            ViewBag.User = user;
            ViewBag.Img = user.Image;
        }
    }
}
