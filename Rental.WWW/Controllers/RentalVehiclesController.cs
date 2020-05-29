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
using Rental.WWW.Controllers.Abstract;
using Rental_Data.Data.Rental;

namespace Rental.WWW.Controllers
{
    public class RentalVehiclesController : BasicAbstractController
    {
        protected readonly ILogger<HomeController> _logger;

        public RentalVehiclesController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        : base(context, userManager)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string search, DateTime? from, DateTime? to, int? fromLocation, int? toLocation, string customer)
        {
            var itemCollection = await _context.RentalVehicles.
                Include(i => i.RentalStatus).
                Include(i => i.Vehicle).
                Include(i => i.Vehicle.Brand).
                Include(i => i.Vehicle.VehicleModel).
                Include(i => i.RentalToLocation).
                Include(i => i.RentalFromLocation).
                Where(w => w.IsActive == true).
                ToListAsync();

            if (search != null)
            {
                itemCollection = itemCollection.Where(w =>
                w.Vehicle.Brand.Name.Contains(search) ||
                w.Vehicle.VehicleModel.Name.Contains(search) ||
                w.Vehicle.NumberPlate.Contains(search)
                ).ToList();
            }

            if (from != null)
            {
                itemCollection = itemCollection.Where(w => w.From.CompareTo(from) != -1).ToList();
            }
            if (to != null)
            {
                itemCollection = itemCollection.Where(w => w.To.CompareTo(to) != 1).ToList();
            }
            if (fromLocation != null)
            {
                itemCollection = itemCollection.Where(w => w.RentalFromLocationId == fromLocation).ToList();
            }
            if (toLocation != null)
            {
                itemCollection = itemCollection.Where(w => w.RentalToLocationId == toLocation).ToList();
            }
            if (customer != null)
            {
                itemCollection = itemCollection.Where(w => w.ApplicationUserID == customer).ToList();
            }

            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            ViewBag.Customers = new SelectList(users, "Id", "Fullname");
            ViewBag.CustomersList = users;
            ViewBag.Cities = new SelectList(_context.RentalAgencyAddresses, "RentalAgencyAddressID", "City");

            //Wczytujemy max i min wartosc obecnie wyswietlanego zapytania
            if (itemCollection.Count > 0)
            {
                ViewBag.FromDate = itemCollection.OrderBy(o => o.From).FirstOrDefault().From.ToString("yyyy-MM-dd");
                ViewBag.ToDate = itemCollection.OrderByDescending(o => o.To).FirstOrDefault().To.ToString("yyyy-MM-dd");
                ViewBag.Search = search;
            }
            return View(itemCollection.OrderBy(o => o.From));
        }


        // GET: RentalVehicles/CreateThis
        public async Task<IActionResult> CreateThis(int? id, string navigation)
        {
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            ViewBag.Customers = new SelectList(users, "Id", "Fullname");

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
            if (navigation != null)
            {
                if (navigation == "next")
                {
                    firstDay = firstDay.AddMonths(1);
                }
                else if (navigation == "previous")
                {
                    firstDay = firstDay.AddMonths(-1);
                }

                HttpContext.Session.SetString("FirstDayofMonth", JsonConvert.SerializeObject(firstDay));
            }

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

            ViewBag.CalendarPage = calendarPage;
            ViewBag.DaysOfWeek = dayscOfWeek;
            ViewBag.Month = calendarPage.ElementAt(15);

            //dopisane do dodania form i to lokalizacji
            var rentalAgencyAddressList = _context.RentalAgencyAddresses.Where(w => w.IsActive == true);
            ViewBag.RentalAgencyAddress = new SelectList(rentalAgencyAddressList, "RentalAgencyAddressID", "City");

            RentalVehicle rv = new RentalVehicle();
            rv.Vehicle = vehicle;

            return View("CreateThis", rv);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateThis([Bind("RentalVehicleID,VehicleID,From,To,RentalStatusID,CreationDate,IsActive,RentalFromLocationId,RentalToLocationId,ApplicationUserID")] RentalVehicle rentalVehicle, List<DateTime> RentalDate)
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
                        _context.Add(new RentalVehicle
                        {

                            VehicleID = rentalVehicle.VehicleID,
                            From = rentalVehicle.From,
                            To = rentalVehicle.To,
                            RentalStatusID = rentalVehicle.RentalStatusID,
                            CreationDate = DateTime.Now,
                            IsActive = true,
                            //dodane
                            RentalFromLocationId = rentalVehicle.RentalFromLocationId,
                            RentalToLocationId = rentalVehicle.RentalToLocationId,
                            ApplicationUserID = rentalVehicle.ApplicationUserID

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

            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "Name", rentalVehicle.RentalStatusID);
            ViewData["VehicleID"] = new SelectList(_context.Vehicles, "VehicleID", "VehicleID", rentalVehicle.VehicleID);

            return View(rentalVehicle);
        }

    }
}