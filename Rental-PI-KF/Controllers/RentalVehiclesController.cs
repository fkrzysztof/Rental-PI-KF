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

        // GET: RentalVehicles/CreateThis
        public async Task<IActionResult> CreateThis(int? id)
        {
            //lepiej zabezpieczyc ?
            if (id == null)
            {
                return NotFound();
            }
            Vehicle vehicle = await _context.Vehicles
                .Include(i => i.Brand)
                .Include(i => i.VehicleModel)
                .Include(i => i.Pictures)
                .Include(i => i.AirConditioning)
                .Include(i => i.GearBox)
                .Include(i => i.ExactType)
                .Include(i => i.Colour)
                .Include(i => i.CurrentPrices)
                .Include(i => i.EngineType)
                .FirstOrDefaultAsync(f => f.VehicleID == id);
            
            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "Name");


            //Kalendarz 
            //dzisiejszy dzien
            DateTime today = DateTime.Now.Date;
            //Jeden dzien do odejmowania
            TimeSpan oneDay = new TimeSpan(1, 0, 0, 0);
            //pierwszy dzien biezacego miesiaca
            DateTime firstDay = new DateTime(today.Year, today.Month, 1);
            //cofamy do poniedzialku
            while (firstDay.DayOfWeek != DayOfWeek.Monday)
            {
                firstDay = firstDay - oneDay;
            }
            List<DateTime> calendarPage = new List<DateTime>();
            for (int i = 0; i < 42; i++)
            {
                calendarPage.Add(new DateTime(firstDay.Year, firstDay.Month, firstDay.Day));
                firstDay = firstDay.AddDays(1);
            }
            //nazwy dni tygodnia
            string[] dayscOfWeek = { "Pn", "Wt", "Śr", "Czw", "Pt", "Sb", "Nd" };

            ViewBag.CalendarPage = calendarPage;
            ViewBag.DaysOfWeek = dayscOfWeek;

            //DateTime firstDay = new DateTime(toDay.Year, toDay.Month, 1);
            //byte startDay = (byte)firstDay.DayOfWeek;

            //int daysOfWeekAll = DateTime.DaysInMonth(toDay.Year, toDay.Month);
            //int x;

            return View("CreateThisTest",vehicle);
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
