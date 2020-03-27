using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using System.Linq;

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
            
            //nie moze byc viewbagow - tylko do testow
            ViewBag.User = user;
            ViewBag.Img = user.Image;
        }
    }
}
