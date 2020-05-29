using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.WWW.Controllers.Abstract;
using Rental_Data.Data.Rental;

namespace Rental.WWW.Controllers
{
    public class VehiclesController : BasicAbstractController
    {
        protected readonly ILogger<HomeController> _logger;

        public VehiclesController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        : base(context, userManager)
        {
            _logger = logger;
        }
        // GET: Vehicles
        public async Task<IActionResult> Index(string generalType, bool table = false)
        {
            var applicationDbContext = _context.Vehicles.
                Include(v => v.Brand).
                Include(v => v.Colour).
                Include(v => v.EngineType).
                Include(v => v.ExactType).
                Include(v => v.GearBox).
                Include(v => v.GeneralType).
                Include(v => v.VehicleModel).
                Include(v => v.WheelDrive).
                Include(v => v.Pictures).
                Include(v => v.Equipment).
                Include(v => v.RentalVehicles).
                Include(v => v.AirConditioning).
                Where(w => w.IsActive == true);

            ViewBag.EQNameList = await _context.EquipmentNames.ToListAsync();
            ViewBag.GeneraltypeNow = generalType;
            ViewBag.Table = table;
            ViewBag.Generaltypes = await _context.GeneralTypes.ToListAsync();

            if (generalType != null)
                return View(await applicationDbContext.Where(w => w.GeneralType.Name == generalType).ToListAsync());
            else
                return View(await applicationDbContext.ToListAsync());
        }
    }
}