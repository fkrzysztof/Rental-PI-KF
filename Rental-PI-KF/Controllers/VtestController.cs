using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental_Data.Data.Rental;

namespace Rental_PI_KF.Controllers
{
    public class VtestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VtestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vtest
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Vehicles.Include(v => v.AirConditioning).Include(v => v.Brand).Include(v => v.Colour).Include(v => v.EngineType).Include(v => v.ExactType).Include(v => v.GearBox).Include(v => v.GeneralType).Include(v => v.RentalAgency).Include(v => v.VehicleModel).Include(v => v.WheelDrive);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Vtest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.AirConditioning)
                .Include(v => v.Brand)
                .Include(v => v.Colour)
                .Include(v => v.EngineType)
                .Include(v => v.ExactType)
                .Include(v => v.GearBox)
                .Include(v => v.GeneralType)
                .Include(v => v.RentalAgency)
                .Include(v => v.VehicleModel)
                .Include(v => v.WheelDrive)
                .FirstOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vtest/Create
        public IActionResult Create()
        {
            ViewData["AirConditioningID"] = new SelectList(_context.AirConditionings, "AirConditioningID", "AirConditioningID");
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandID");
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "ColourID");
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "EngineTypeID");
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "ExactTypeID");
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "GearBoxID");
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID");
            ViewData["RentalAgencyID"] = new SelectList(_context.RentalAgencies, "RentalAgencyID", "RentalAgencyID");
            ViewData["VehicleModelID"] = new SelectList(_context.VehicleModels, "VehicleModelID", "VehicleModelID");
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "WheelDriveID");
            return View();
        }

        // POST: Vtest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,YearOfCarProduction,RentalAgencyID,EngineCapacity,AirConditioningID,Description,GeneralTypeID,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,DateIn,DateOut,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,IsActive")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AirConditioningID"] = new SelectList(_context.AirConditionings, "AirConditioningID", "AirConditioningID", vehicle.AirConditioningID);
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandID", vehicle.BrandID);
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "ColourID", vehicle.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "EngineTypeID", vehicle.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "ExactTypeID", vehicle.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "GearBoxID", vehicle.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", vehicle.GeneralTypeID);
            ViewData["RentalAgencyID"] = new SelectList(_context.RentalAgencies, "RentalAgencyID", "RentalAgencyID", vehicle.RentalAgencyID);
            ViewData["VehicleModelID"] = new SelectList(_context.VehicleModels, "VehicleModelID", "VehicleModelID", vehicle.VehicleModelID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "WheelDriveID", vehicle.WheelDriveID);
            return View(vehicle);
        }

        // GET: Vtest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["AirConditioningID"] = new SelectList(_context.AirConditionings, "AirConditioningID", "AirConditioningID", vehicle.AirConditioningID);
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandID", vehicle.BrandID);
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "ColourID", vehicle.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "EngineTypeID", vehicle.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "ExactTypeID", vehicle.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "GearBoxID", vehicle.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", vehicle.GeneralTypeID);
            ViewData["RentalAgencyID"] = new SelectList(_context.RentalAgencies, "RentalAgencyID", "RentalAgencyID", vehicle.RentalAgencyID);
            ViewData["VehicleModelID"] = new SelectList(_context.VehicleModels, "VehicleModelID", "VehicleModelID", vehicle.VehicleModelID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "WheelDriveID", vehicle.WheelDriveID);
            return View(vehicle);
        }

        // POST: Vtest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,YearOfCarProduction,RentalAgencyID,EngineCapacity,AirConditioningID,Description,GeneralTypeID,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,DateIn,DateOut,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,IsActive")] Vehicle vehicle)
        {
            if (id != vehicle.VehicleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.VehicleID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AirConditioningID"] = new SelectList(_context.AirConditionings, "AirConditioningID", "AirConditioningID", vehicle.AirConditioningID);
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandID", vehicle.BrandID);
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "ColourID", vehicle.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "EngineTypeID", vehicle.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "ExactTypeID", vehicle.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "GearBoxID", vehicle.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", vehicle.GeneralTypeID);
            ViewData["RentalAgencyID"] = new SelectList(_context.RentalAgencies, "RentalAgencyID", "RentalAgencyID", vehicle.RentalAgencyID);
            ViewData["VehicleModelID"] = new SelectList(_context.VehicleModels, "VehicleModelID", "VehicleModelID", vehicle.VehicleModelID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "WheelDriveID", vehicle.WheelDriveID);
            return View(vehicle);
        }

        // GET: Vtest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.AirConditioning)
                .Include(v => v.Brand)
                .Include(v => v.Colour)
                .Include(v => v.EngineType)
                .Include(v => v.ExactType)
                .Include(v => v.GearBox)
                .Include(v => v.GeneralType)
                .Include(v => v.RentalAgency)
                .Include(v => v.VehicleModel)
                .Include(v => v.WheelDrive)
                .FirstOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vtest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicles.Any(e => e.VehicleID == id);
        }
    }
}
