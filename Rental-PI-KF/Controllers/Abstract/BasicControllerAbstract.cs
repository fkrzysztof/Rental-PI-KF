using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_PI_KF.Controllers.Abstract
{
    
    [Authorize(Roles = "Administrator,Pracownik")]
    public class BasicControllerAbstract : Controller
    {
        protected readonly UserManager<ApplicationUser> _userManager;
        protected readonly ApplicationDbContext _context;
        
        public BasicControllerAbstract(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        //public void GeneralTypeToMenu()
        //{
        //    ViewBag.GeneralTypesList = _context.GeneralTypes.ToList();
        //}

        public ApplicationUser GetUser()
        {
            return _userManager.FindByNameAsync(User.Identity.Name).Result;
        }

        public string GetUserRoleName()
        {
            return _userManager.GetRolesAsync(GetUser()).Result.First();
        }

    }
}
