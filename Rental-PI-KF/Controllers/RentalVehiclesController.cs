using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.Data.Data.Rental;
using Rental_Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    public class RentalVehiclesController : BasicControllerAbstract
    {
        //private readonly ApplicationDbContext _context;

        //public RentalVehiclesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        //: base(context, userManager)        
        
        public RentalVehiclesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        : base(context, userManager)
        {
        }

        // GET: RentalVehicles
        public async Task<IActionResult> Index()
        {
            UserProfile();
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
        public async Task<IActionResult> CreateThis(int? id, string navigation)
        {
            UserProfile();

            //lepiej zabezpieczyc ?
            if (id == null)
            {
                return NotFound();
            }
            //Kalendarz 
            DateTime today = DateTime.Now.Date;
            //pierwszy dzien biezacego miesiaca
            DateTime firstDay;

            //ustawiam session na aktualnie wybrany miesiac lub dzisiejsza date
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("FirstDayofMonth")))
            {
                //jesli nie mamy zmiennej w sesji ustawiamy dzisiejszy dzien
                firstDay = new DateTime(today.Year, today.Month, 1);
                HttpContext.Session.SetString("FirstDayofMonth", JsonConvert.SerializeObject(firstDay));
            }
            else
            {
                firstDay = JsonConvert.DeserializeObject<DateTime>(HttpContext.Session.GetString("FirstDayofMonth"));
            }
           



            //Dodaje lub odejmuje miesiac NEXT - PREVIOUS oraz aktualizuje zmienna w sesji
            if(navigation != null)
            { 
                if(navigation == "next")
                {
                    firstDay = firstDay.AddMonths(1);
                }
                else if(navigation == "previous")
                {
                    firstDay = firstDay.AddMonths(-1);
                }

                HttpContext.Session.SetString("FirstDayofMonth", JsonConvert.SerializeObject(firstDay));
            }

                                                                //co kiedy dzisiaj jest pierwszy ???

            //cofamy do poniedzialku
            while (firstDay.DayOfWeek != DayOfWeek.Monday)
            {
                firstDay = firstDay.AddDays(-1);
            }
            List<DateTime> calendarPage = new List<DateTime>();
            for (int i = 0; i < 42; i++)
            {
                calendarPage.Add(new DateTime(firstDay.Year, firstDay.Month, firstDay.Day));
                firstDay = firstDay.AddDays(1);
            }
            //nazwy dni tygodnia
            string[] dayscOfWeek = { "Pn", "Wt", "Śr", "Czw", "Pt", "Sb", "Nd" };

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
                .Include(i => i.RentalVehicles)
                .FirstOrDefaultAsync(f => f.VehicleID == id);
            
            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "Name");

            //Where(w => w.From.CompareTo(calendarPage.First()) > -1 &&
            //                w.To.CompareTo(calendarPage.Last()) > 0))


            ViewBag.CalendarPage = calendarPage;
            ViewBag.DaysOfWeek = dayscOfWeek;
            ViewBag.Month = calendarPage.ElementAt(15); // do podswietlania wlasciwego miesiaca
            //ViewBag.RentalStatusID = new SelectList(_context.RentalStatuses, "RentalVehicleID", "Name");
            //dopisane
            //ViewBag.Vehicle = vehicle;

            RentalVehicle rv = new RentalVehicle();
            rv.Vehicle = vehicle;

            return View("CreateThisTest",rv);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateThis([Bind("RentalVehicleID,VehicleID,From,To,RentalStatusID,CreationDate,IsActive")] RentalVehicle rentalVehicle, List<DateTime> RentalDate)
        {
            if (ModelState.IsValid)
            {
                //sprawdzanie zaznaczonych pozycji w kalendarzu
                RentalDate.Sort();
                rentalVehicle.From = RentalDate.ElementAt(0);
                for (int i = 0; i < RentalDate.Count(); i++)
                {
                    //ostatni lub jedyny 
                    if ((i + 1) == RentalDate.Count)
                    {
                        rentalVehicle.To = RentalDate.ElementAt(i).Date;
                        _context.Add(new RentalVehicle { 
                        
                            VehicleID = rentalVehicle.VehicleID,
                            From = rentalVehicle.From,
                            To = rentalVehicle.To,
                            RentalStatusID = rentalVehicle.RentalStatusID,
                            CreationDate = DateTime.Now,
                            IsActive = true
                        
                        });
                        break;
                    }
                    //nastepny dzien rezerwacji to nie kolejny dzien!
                    //konczymy ta rezerwacje zaczynamy nawa
                    if (RentalDate.ElementAt(i).AddDays(1).Date != RentalDate.ElementAt(i + 1).Date)
                    {
                        rentalVehicle.To = RentalDate.ElementAt(i).Date;
                        _context.Add(new RentalVehicle
                        {

                            VehicleID = rentalVehicle.VehicleID,
                            From = rentalVehicle.From,
                            To = rentalVehicle.To,
                            RentalStatusID = rentalVehicle.RentalStatusID,
                            CreationDate = DateTime.Now,
                            IsActive = true

                        });

                        //podanie nowej zawartosci for
                        rentalVehicle.From = RentalDate.ElementAt(i + 1).Date;

                    }
                }
                await _context.SaveChangesAsync();
            
                return RedirectToAction(nameof(Index));
            
            }

            UserProfile();
            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "Name", rentalVehicle.RentalStatusID);
            ViewData["VehicleID"] = new SelectList(_context.Vehicles, "VehicleID", "VehicleID", rentalVehicle.VehicleID);
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
