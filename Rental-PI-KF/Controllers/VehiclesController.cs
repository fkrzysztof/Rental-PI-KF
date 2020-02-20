using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
//using Rental.Data.Data.HelpersClass;
using Rental_Data.Data.Rental;

namespace Rental_PI_KF.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehiclesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Vehicles.Include(v => v.Brand).Include(v => v.Colour).Include(v => v.EngineType).Include(v => v.ExactType).Include(v => v.GearBox).Include(v => v.GeneralType).Include(v => v.VehicleModel).Include(v => v.WheelDrive);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Colour)
                .Include(v => v.EngineType)
                .Include(v => v.ExactType)
                .Include(v => v.GearBox)
                .Include(v => v.GeneralType)
                .Include(v => v.VehicleModel)
                .Include(v => v.WheelDrive)
                .FirstOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {

            //podejscie 3
            List<Brand> brandList = new List<Brand>();
            brandList = _context.Brands.ToList();
            brandList.Insert(0, new Brand { BrandID = 0, Name = "Select" });
            ViewBag.ListOfBrads = brandList;



            //ViewBag.Brands = _context.Brands.ToList();
            //ViewBag.BrandID = new SelectList(_context.Brands, "BrandID", "Name"); //zmiana
            //ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "Name"); //zmiana
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "Name");
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "Name");
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "Name");
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "Name");
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name");
            ViewBag.ModelList = new SelectList(_context.VehicleModels, "VehicleModelID", "Name"); //na chwile
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "Name");

            //dodane
            ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type");
            

            return View();
        }

        //JS 
        public JsonResult GetModel( int BrandID)
        {
            List<VehicleModel> vehicleModelsList = new List<VehicleModel>();
            vehicleModelsList = _context.VehicleModels.Where(x => x.BrandID == BrandID).ToList();
            vehicleModelsList.Insert(0, new VehicleModel { VehicleModelID = 0, Name = "select" });
            return Json(new SelectList(vehicleModelsList, "VehicleModelID", "Name"));
        }




        //public JsonResult GetModelByID(int id)
        //{
        //    List<VehicleModel> VehicleModelsList = new List<VehicleModel>();
        //    VehicleModelsList  = _context.VehicleModels.Where(x => x.BrandID == id).ToList();
        //    VehicleModelsList.Insert(0, new VehicleModel { VehicleModelID = 0, Name = "Wybierz model Auta" });
        //    return Json(new SelectList(VehicleModelsList, "VehicleModelID", "Name"));
        //}



        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,EngineCapacity,Description,GeneralTypeID,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,DateIn,DateOut,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,IsActive")] Vehicle vehicle)
        //public async Task<IActionResult> Create([Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,EngineCapacity,Description,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,IsActive")] Vehicle vehicle)
        public async Task<IActionResult> Create(Vehicle v)
        {
            if (ModelState.IsValid)
            {
                _context.Add(v);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // to jest do sprawdzenia !!!
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandID", v.BrandID);
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "ColourID", v.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "EngineTypeID", v.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "ExactTypeID", v.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "GearBoxID", v.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", v.GeneralTypeID);
            ViewData["VehicleModelID"] = new SelectList(_context.VehicleModels, "VehicleModelID", "VehicleModelID", v.VehicleModelID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "WheelDriveID", v.WheelDriveID);

            ViewData["AirConditioningID"] = new SelectList(_context.AirConditionings, "AirConditioningID", "Name");
            return View(v);
        }

        // GET: Vehicles/Edit/5
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
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandID", vehicle.BrandID);
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "ColourID", vehicle.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "EngineTypeID", vehicle.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "ExactTypeID", vehicle.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "GearBoxID", vehicle.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", vehicle.GeneralTypeID);
            ViewData["VehicleModelID"] = new SelectList(_context.VehicleModels, "VehicleModelID", "VehicleModelID", vehicle.VehicleModelID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "WheelDriveID", vehicle.WheelDriveID);
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,EngineCapacity,Description,GeneralTypeID,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,DateIn,DateOut,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,IsActive")] Vehicle vehicle)
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
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandID", vehicle.BrandID);
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "ColourID", vehicle.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "EngineTypeID", vehicle.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "ExactTypeID", vehicle.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "GearBoxID", vehicle.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", vehicle.GeneralTypeID);
            ViewData["VehicleModelID"] = new SelectList(_context.VehicleModels, "VehicleModelID", "VehicleModelID", vehicle.VehicleModelID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "WheelDriveID", vehicle.WheelDriveID);
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Colour)
                .Include(v => v.EngineType)
                .Include(v => v.ExactType)
                .Include(v => v.GearBox)
                .Include(v => v.GeneralType)
                .Include(v => v.VehicleModel)
                .Include(v => v.WheelDrive)
                .FirstOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
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
