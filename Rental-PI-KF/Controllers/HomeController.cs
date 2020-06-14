using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_PI_KF.Controllers.Abstract;
using Rental_PI_KF.Models;

namespace Rental_PI_KF.Controllers
{
    public class HomeController : BasicControllerAbstract
    {
        protected readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        : base(context, userManager)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var query = _context.RentalVehicles
                .Include(r => r.Vehicle.Brand).Include(r => r.Vehicle.VehicleModel)
                .GroupBy(g => g.Vehicle.Brand.Name)
                .Select(s => new { name = s.Key, nameCount = s.Count()})
                .OrderBy(o => o.nameCount)
                .Take(5)
                .ToList();

            ViewBag.Brands = query.Select(s => s.name).ToArray();
            //news
            ViewBag.ItemCollection = await _context.News.Include(n => n.SenderUser).ToListAsync();
            var users = _userManager.Users.ToList();

            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
