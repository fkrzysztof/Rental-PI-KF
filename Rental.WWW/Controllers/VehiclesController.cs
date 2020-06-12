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
        //public async Task<IActionResult> Index(string generalType, bool table = false)
        //{
        //    var applicationDbContext = _context.Vehicles.
        //        Include(v => v.Brand).
        //        Include(v => v.Colour).
        //        Include(v => v.EngineType).
        //        Include(v => v.ExactType).
        //        Include(v => v.GearBox).
        //        Include(v => v.GeneralType).
        //        Include(v => v.VehicleModel).
        //        Include(v => v.WheelDrive).
        //        Include(v => v.Pictures).
        //        Include(v => v.Equipment).
        //        Include(v => v.RentalVehicles).
        //        Include(v => v.AirConditioning).
        //        Where(w => w.IsActive == true);

        //    ViewBag.EQNameList = await _context.EquipmentNames.ToListAsync();
        //    ViewBag.GeneraltypeNow = generalType;
        //    ViewBag.Table = table;
        //    ViewBag.Generaltypes = await _context.GeneralTypes.ToListAsync();

        //    if (generalType != null)
        //        return View(await applicationDbContext.Where(w => w.GeneralType.Name == generalType).ToListAsync());
        //    else
        //        return View(await applicationDbContext.ToListAsync());
        //}


        public async Task<IActionResult> Index(string generalType, string search, int? exactType, int? gearBox, int? engineType,
                                       int? enginePower, int? rentalItemBrand, string cut, bool table = false)
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
                Where(w => w.IsActive == true).
                ToList();

            if (generalType != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.GeneralType.Name == generalType).ToList();
            }

            ViewBag.EQNameList = await _context.EquipmentNames.ToListAsync();
            ViewBag.GeneraltypeNow = generalType;
            //ViewBag.Active = active;
            ViewBag.Table = table;
            ViewBag.Generaltypes = await _context.GeneralTypes.ToListAsync();

            #region dodatkowe opcje wyszukiwania

            if (search != null)
            {
                List<string> searchList = search.ToLower().Split(" ").ToList();

                if (cut != null)
                    searchList.Remove(cut);

                applicationDbContext = applicationDbContext.Where(w =>
                searchList.Contains(w.Brand.Name.ToLower()) ||
                searchList.Contains(w.VehicleModel.Name.ToLower()) ||
                searchList.Contains(w.Colour.Name.ToLower()) ||
                searchList.Contains(w.WheelDrive.Name.ToLower())
                ).ToList();
                ViewBag.Search = searchList;
                ViewBag.SearchString = string.Join(" ", searchList);
            }


            if (exactType != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.ExactTypeID == exactType).ToList();
                ViewBag.ExactType = new SelectList(applicationDbContext.Select(s => s.ExactType).Distinct(), "ExactTypeID", "Name", exactType);
            }
            else
            {
                ViewBag.ExactType = new SelectList(applicationDbContext.Select(s => s.ExactType).Distinct(), "ExactTypeID", "Name");
            }

            if (gearBox != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.GearBoxID == gearBox).ToList();
                ViewBag.GearBox = new SelectList(_context.GearBoxes, "GearBoxID", "Name", gearBox);
            }
            else
            {
                ViewBag.GearBox = new SelectList(_context.GearBoxes, "GearBoxID", "Name");
            }

            if (engineType != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.EngineTypeID == engineType).ToList();
                ViewBag.EngineType = new SelectList(_context.EngineTypes, "EngineTypeID", "Name", engineType);
            }
            else
            {
                ViewBag.EngineType = new SelectList(_context.EngineTypes, "EngineTypeID", "Name");
            }

            if (enginePower != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.EnginePower >= enginePower).ToList();
                ViewBag.EnginePower = enginePower;
            }


            if (rentalItemBrand != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.BrandID == rentalItemBrand).ToList();
                ViewBag.RentalItemBrand = new SelectList(_context.Brands, "BrandID", "Name", rentalItemBrand);
            }
            else
            {
                ViewBag.RentalItemBrand = new SelectList(_context.Brands, "BrandID", "Name", rentalItemBrand);
            }

            #endregion dodatkowe opcje wyszukiwania

            return View(applicationDbContext);
        }

    }
}