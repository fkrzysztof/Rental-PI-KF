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

        public BasicControllerAbstract(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public void GeneralTypeToMenu()
        {
            ViewBag.GeneralTypesList = _context.GeneralTypes.ToList();
        }
    }
}
