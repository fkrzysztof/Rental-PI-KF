using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Data.Data.Rental;
using Rental_Data.Data.Rental;

namespace Rental_PI_KF.Controllers
{
    public class RentalVehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalVehiclesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentalVehicles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RentalVehicles.Include(r => r.RentalStatus).Include(r => r.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RentalVehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalVehicle = await _context.RentalVehicles
                .Include(r => r.RentalStatus)
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.RentalVehicleID == id);
            if (rentalVehicle == null)
            {
                return NotFound();
            }

            return View(rentalVehicle);
        }

        // GET: RentalVehicles/Create
        public IActionResult Create()
        {
            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "RentalStatusID");
            List<Vehicle> vehicleList = _context.Vehicles.Include(i => i.VehicleModel).Include(i => i.Brand).Where(w => w.Blockade == false).ToList();
            //doac isActive
            foreach (var itemVehicle in vehicleList)
            {
                itemVehicle.Name = itemVehicle.Brand.Name + " " + itemVehicle.VehicleModel.Name + " /NR.R. " + itemVehicle.NumberPlate;
            }
            ViewData["VehicleID"] = new SelectList(vehicleList, "VehicleID", "Name");
            //ViewData["VehicleID"] = new SelectList(_context.Vehicles, "VehicleID", "Name");
            return View();
        }

        // POST: RentalVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalVehicleID,VehicleID,From,To,RentalStatusID,CreationDate,IsActive")] RentalVehicle rentalVehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalVehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "RentalStatusID", rentalVehicle.RentalStatusID);
            ViewData["VehicleID"] = new SelectList(_context.Vehicles, "VehicleID", "VehicleID", rentalVehicle.VehicleID);
            return View(rentalVehicle);
        }

        // GET: RentalVehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalVehicle = await _context.RentalVehicles.FindAsync(id);
            if (rentalVehicle == null)
            {
                return NotFound();
            }
            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "RentalStatusID", rentalVehicle.RentalStatusID);
            ViewData["VehicleID"] = new SelectList(_context.Vehicles, "VehicleID", "VehicleID", rentalVehicle.VehicleID);
            return View(rentalVehicle);
        }

        // POST: RentalVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalVehicleID,VehicleID,From,To,RentalStatusID,CreationDate,IsActive")] RentalVehicle rentalVehicle)
        {
            if (id != rentalVehicle.RentalVehicleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalVehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalVehicleExists(rentalVehicle.RentalVehicleID))
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
            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "RentalStatusID", rentalVehicle.RentalStatusID);
            ViewData["VehicleID"] = new SelectList(_context.Vehicles, "VehicleID", "VehicleID", rentalVehicle.VehicleID);
            return View(rentalVehicle);
        }

        // GET: RentalVehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalVehicle = await _context.RentalVehicles
                .Include(r => r.RentalStatus)
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.RentalVehicleID == id);
            if (rentalVehicle == null)
            {
                return NotFound();
            }

            return View(rentalVehicle);
        }

        // POST: RentalVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalVehicle = await _context.RentalVehicles.FindAsync(id);
            _context.RentalVehicles.Remove(rentalVehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalVehicleExists(int id)
        {
            return _context.RentalVehicles.Any(e => e.RentalVehicleID == id);
        }
    }
}
