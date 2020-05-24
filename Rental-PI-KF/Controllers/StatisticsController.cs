using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    public class StatisticsController : BasicControllerAbstract
    {
        public StatisticsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        : base(context, userManager)
        {
        }

        public IActionResult Index()
        {
            var query = _context.Vehicles
            .Include(r => r.Brand).Include(r => r.VehicleModel)
            .GroupBy(g => g.Brand.Name)
            .Select(s => new { name = s.Key }).ToList();
            ViewBag.Brands = query;

            return View();
        }

        //char 5
        public ActionResult GetData()
        {
            int a = _context.RentalVehicles.Where(w => w.IsActive == true).Count();
                

            var query = _context.RentalVehicles
                .Where(w => w.IsActive == true)
                .Include(r => r.Vehicle.Brand).Include(r => r.Vehicle.VehicleModel)
                .GroupBy(g => g.Vehicle.Brand.Name)
                .Select(s => new { name = s.Key, nameCount = s.Count(), all = a })
                .OrderBy(o => o.nameCount)
                .Take(5)
                .ToList();

            return Json(query);
        }

        public ActionResult GetDataCarAll()
        {
            int a = _context.RentalVehicles.Where(w => w.IsActive == true).Count();

            var query = _context.RentalVehicles
                .Where(w => w.IsActive == true)
                .Include(r => r.Vehicle.ExactType)
                .GroupBy(g => g.Vehicle.ExactType.Name)
                .OrderBy(g => g.Count())
                .Select(s => new { name = s.Key, nameCount = s.Count(), all = a }).ToList();

            return Json(query);
        }
        
        //area
        public ActionResult GetDataRentalAll()
        {
            int a = _context.Vehicles.Count();

            var query = _context.RentalVehicles
                .GroupBy(g => g.From.Month)
                .Select(s => new { name = s.Key, nameCount = s.Count(), all = a })
                .ToList();

            return Json(query);
        }
    }
}