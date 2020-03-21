using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        public BasicControllerAbstract(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
          _userManager = userManager;
          _context = context;
            
        }

        public void ImgProfile()
        {
            var id = _userManager.GetUserId(HttpContext.User);
            var us = _userManager.Users;
            var u = us.FirstOrDefault(f => f.Id == id);
            ViewBag.Img = u.Image;
        }
    }
}
