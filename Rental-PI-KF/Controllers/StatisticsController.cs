using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ActionResult GetData()
        {
            int a = _context.Vehicles.Count();

            var query = _context.Vehicles
                .Include(r => r.Brand).Include(r => r.VehicleModel)
                .GroupBy(g => g.Brand.Name)
                .Select(s => new { name = s.Key, nameCount = s.Count(), all = a }).ToList();

            return Json(query);
        }

        public ActionResult GetDataCarAll()
        {
            int a = _context.Vehicles.Count();

            var query = _context.Vehicles
                .Include(r => r.Brand).Include(r => r.VehicleModel)
                .GroupBy(g => g.VehicleModel.Name)
                .OrderBy(g => g.Count())
                .Select(s => new { name = s.Key, nameCount = s.Count(), all = a }).ToList();

            return Json(query);
        }
        public ActionResult GetDataRentalAll()
        {
            int a = _context.Vehicles.Count();

            var query = _context.RentalVehicles
                //.Include(r => r.Brand).Include(r => r.VehicleModel)
                .GroupBy(g => g.From)
                .Select(s => new { name = s.Key.Date.ToShortDateString(), nameCount = s.Count(), all = a }).ToList();

            return Json(query);
        }
    }
}