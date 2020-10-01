using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.Data.Data.Rental;
using Rental_Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;
using SelectPdf;

namespace Rental_PI_KF.Controllers
{
    public class RentalVehiclesController : BasicControllerAbstract
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RentalVehiclesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        : base(context, userManager)
        {
            _roleManager = roleManager;
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

            if( from != null)
            {
                itemCollection = itemCollection.Where(w => w.From.CompareTo(from) != -1).ToList();
            }
            if( to != null)
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

            List <ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            ViewBag.Customers = new SelectList(users, "Id", "Fullname");
            ViewBag.CustomersList = users;
            ViewBag.Cities = new SelectList(_context.RentalAgencyAddresses, "RentalAgencyAddressID", "City");

            //Wczytujemy max i min wartosc obecnie wyswietlanego zapytania
            if(itemCollection.Count > 0)
            { 
            ViewBag.FromDate = itemCollection.OrderBy(o => o.From).FirstOrDefault().From.ToString("yyyy-MM-dd");
            ViewBag.ToDate = itemCollection.OrderByDescending(o => o.To).FirstOrDefault().To.ToString("yyyy-MM-dd");
            ViewBag.Search = search;
            }
            return View(itemCollection.OrderBy(o => o.From));
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
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            ViewBag.Customers = new SelectList(users, "Id", "Fullname");

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

            //do poniedzialku
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

            return View("CreateThis",rv);
        }

        private async void AddRentalVehicle(RentalVehicle rv)
        {
            await _context.AddAsync(new RentalVehicle
            {
                VehicleID = rv.VehicleID,
                From = rv.From,
                To = rv.To,
                RentalStatusID = rv.RentalStatusID,
                CreationDate = DateTime.Now,
                IsActive = true,
                RentalFromLocationId = rv.RentalFromLocationId,
                RentalToLocationId = rv.RentalToLocationId,
                ApplicationUserID = rv.ApplicationUserID
            });
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
                        AddRentalVehicle(rentalVehicle);
                        break;
                    }
                    //nastepny dzien rezerwacji to nie kolejny dzien!
                    //konczymy ta rezerwacje zaczynamy nowa
                    if (RentalDate.ElementAt(i).AddDays(1).Date != RentalDate.ElementAt(i + 1).Date)
                    {
                        rentalVehicle.To = RentalDate.ElementAt(i).Date;
                        AddRentalVehicle(rentalVehicle);

                        //podanie nowej zawartosci from
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


        // GET: RentalVehicles/Create
        public IActionResult Create()
        {
            List<Vehicle> vehicleList = _context.Vehicles.
                Include(i => i.VehicleModel).
                Include(i => i.Brand).
                Where(w => w.Blockade != true).
                ToList();

            foreach (var itemVehicle in vehicleList)
            {
                itemVehicle.Name = itemVehicle.Brand.Name + " " + itemVehicle.VehicleModel.Name + " /NR.R. " + itemVehicle.NumberPlate;
            }

            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "Name");
            ViewBag.Vehicles = new SelectList(vehicleList, "VehicleID", "Name");
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            ViewBag.Customers = new SelectList(users, "Id", "Fullname");
            ViewBag.Cities = new SelectList(_context.RentalAgencyAddresses.Where(w => w.RentalAgency.IsActive == true), "RentalAgencyAddressID", "City");

            return View();
        }

        // POST: RentalVehicles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("From,To,RentalStatusID,RentalFromLocationId,RentalToLocationId,Annotations,VehicleID,ApplicationUserID")] RentalVehicle rentalVehicle)
        {
            if (ModelState.IsValid)
            {
                rentalVehicle.CreationDate = DateTime.Now;
                rentalVehicle.IsActive = true;
                _context.Add(rentalVehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RentalStatusID"] = new SelectList(_context.RentalStatuses, "RentalStatusID", "RentalStatusID", rentalVehicle.RentalStatusID);
            ViewData["VehicleID"] = new SelectList(_context.Vehicles.Where(w => w.IsActive == true && w.Blockade != true), "VehicleID", "VehicleID", rentalVehicle.VehicleID);
            return View(rentalVehicle);
        }

        // GET: RentalVehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalVehicle = _context.RentalVehicles.
                Include(i => i.RentalFromLocation).
                Include(i => i.RentalToLocation).
                Include(i => i.RentalStatus).
                Include(i => i.Vehicle).
                Include(i => i.Vehicle.AirConditioning).
                Include(i => i.Vehicle.EngineType).
                Include(i => i.Vehicle.ExactType).
                Include(i => i.Vehicle.Colour).
                Include(i => i.Vehicle.GearBox).
                Include(i => i.Vehicle.WheelDrive).
                Include(i => i.Vehicle.Brand).
                Include(i => i.Vehicle.VehicleModel).
                First(f => f.RentalVehicleID == id);
            
            if (rentalVehicle == null)
            {
                return NotFound();
            }
            
            ViewBag.RentalStatusID = new SelectList(_context.RentalStatuses, "RentalStatusID", "Name", rentalVehicle.RentalStatusID);
            ViewBag.CustomersNow = await _userManager.FindByIdAsync(rentalVehicle.ApplicationUserID);
            ViewBag.CitiesFrom = new SelectList(_context.RentalAgencyAddresses, "RentalAgencyAddressID", "City", rentalVehicle.RentalFromLocation.RentalAgencyAddressID );
            ViewBag.CitiesTo = new SelectList(_context.RentalAgencyAddresses, "RentalAgencyAddressID", "City", rentalVehicle.RentalToLocation.RentalAgencyAddressID );

            return View(rentalVehicle);
        }

        //POST: RentalVehicles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Full Edit
        //public async Task<IActionResult> Edit(int id, [Bind("RentalVehicleID,From,To,RentalStatusID,RentalFromLocationId,RentalToLocationId,Annotations")] RentalVehicle rentalVehicle)
        public async Task<IActionResult> Edit(int id, [Bind("RentalVehicleID,RentalFromLocationId,RentalToLocationId,Annotations")] RentalVehicle rentalVehicle)
        {
            if (id != rentalVehicle.RentalVehicleID)
            {
                return NotFound();
            }
            var rv = await _context.RentalVehicles.FirstOrDefaultAsync(w => w.RentalVehicleID == id);

            if (ModelState.IsValid)
            {
                try
                {
                    //rv.From = rentalVehicle.From;
                    //rv.To = rentalVehicle.To;
                    //rv.RentalStatusID = rentalVehicle.RentalStatusID;
                    rv.RentalFromLocationId = rentalVehicle.RentalFromLocationId;
                    rv.RentalToLocationId = rentalVehicle.RentalToLocationId;
                    rv.Annotations = rentalVehicle.Annotations;
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

            ViewBag.RentalStatusID = new SelectList(_context.RentalStatuses, "RentalStatusID", "Name", rentalVehicle.RentalStatusID);
            ViewBag.CustomersNow = await _userManager.FindByIdAsync(rv.ApplicationUserID);
            ViewBag.CitiesFrom = new SelectList(_context.RentalAgencyAddresses, "RentalAgencyAddressID", "City", rentalVehicle.RentalFromLocation.RentalAgencyAddressID);
            ViewBag.CitiesTo = new SelectList(_context.RentalAgencyAddresses, "RentalAgencyAddressID", "City", rentalVehicle.RentalToLocation.RentalAgencyAddressID);

            return View(rentalVehicle);
        }


        // POST: RentalVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalVehicle = await _context.RentalVehicles.FindAsync(id);
            rentalVehicle.IsActive = false;
            _context.RentalVehicles.Update(rentalVehicle);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> GeneratePdf(int id)
        {
            var rentalVehicle = _context.RentalVehicles.
             Include(i => i.RentalFromLocation).
             Include(i => i.RentalToLocation).
             Include(i => i.RentalStatus).
             Include(i => i.Vehicle).
             Include(i => i.Vehicle.Brand).
             Include(i => i.Vehicle.VehicleModel).
             Include(i => i.Vehicle.EngineType).
             Include(i => i.Vehicle.Equipment).
             Include(i => i.Vehicle.AirConditioning).
             First(f => f.RentalVehicleID == id);

            var eqnName = _context.EquipmentNames.ToList();
            string eqString = "";
            int countLst = rentalVehicle.Vehicle.Equipment.Count;
            foreach (var eq in rentalVehicle.Vehicle.Equipment)
            {
                eqString += eqnName.Where(w => w.EquipmentNameID == eq.EquipmentNameID).Select(s => s.Name).FirstOrDefault();
                if (countLst-- > 1)
                    eqString += ", ";
                else
                    eqString += " .";
            }

            var user = await _userManager.FindByIdAsync(rentalVehicle.ApplicationUserID);
            var agency = _context.RentalAgencies.
                Include(i => i.RentalAgencyAddress).
                FirstOrDefault(w => w.RentalAgencyID == rentalVehicle.Vehicle.RentalAgencyID);

            string htmlcode =
            "<table style=\"width: 100%\"><tr><td align=\"left\">" +
            "<h3>" + "RentIT" + "<h3>" +
            "</td><td align=\"right\">" +
            "<h3>" + DateTime.Now.ToShortDateString() + "<h3>" +
            "</td></tr></table><br>" +
            "<h1>Potwierdzenie rezerwacji pojazdu</h2>" +
            "<hr />" +
            "<h2>Dane Pojazdy:</h3>" +
            "<table style=\"border: 1px solid black; padding: 5px; font-size: 24px; width: 100%; \">" +
              "<tbody>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Marka i model</td>" +
                      "<td><b>" + rentalVehicle.Vehicle.Brand.Name + " " + rentalVehicle.Vehicle.VehicleModel.Name + "</b> /"
                      + rentalVehicle.Vehicle.YearOfCarProduction + " " + rentalVehicle.Vehicle.EngineType.Name + " "
                      + String.Format("{0:0.0}", Math.Round(((Convert.ToDouble(rentalVehicle.Vehicle.EngineCapacity)) / 1000), 2)) + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">VIN / Numer rejestracyjny</td>" +
                      "<td>" + rentalVehicle.Vehicle.VIN + " / " + rentalVehicle.Vehicle.NumberPlate + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Wyposażenie</td>" +
                      "<td>" + eqString + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Klimatyzacja</td>" +
                      "<td>" + rentalVehicle.Vehicle.AirConditioning.Type + "</td>" +
                  "</tr>" +
              "</tbody>" +
             "</table>" +
             "<h2>Rezerwacja:</h3>" +
            "<table style=\"border: 1px solid black; padding: 5px; font-size: 24px; width: 100%; \">" +
              "<tbody>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Data wypożyczenia</td>" +
                      "<td>" + rentalVehicle.CreationDate + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\"Odbiór pojazdu</td>" +
                      "<td><b>" + rentalVehicle.From.ToShortDateString() + "</b></td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Zwrot pojazdu</td>" +
                      "<td><b>" + rentalVehicle.To.ToShortDateString() + "</b></td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Miejsce odbioru</td>" +
                      "<td>" + rentalVehicle.RentalFromLocation.City + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Miejsce zwrotu</td>" +
                      "<td>" + rentalVehicle.RentalToLocation.City + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Status rezerwacji</td>" +
                      "<td>" + rentalVehicle.RentalStatus.Name + "</td>" +
                  "</tr>" +
               "</tbody>" +
             "</table>" +
             "<h2>Dane Klienta:</h3>" +
             "<table style=\"border: 1px solid black; padding: 5px; font-size: 24px; width: 100%; \">" +
              "<tbody>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Imię i Nazwisko</td>" +
                      "<td>" + user.FirstName + " " + user.LastName + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Adres</td>" +
                      "<td>" + user.Street + " " + user.Number +
                      "<br>" + user.ZIPCode + " " + user.City + ", " + user.Country + " </td>" +
                  "</tr>" +

                  "<tr>" +
                       "<td style=\"width:40%;\">Telefon</td>" +
                      "<td> Telefon:" + user.PhoneNumber + "</td>" +
                  "</tr>" +

                  "<tr>" +
                       "<td style=\"width:40%;\">E-mail</td>" +
                      "<td>" + user.Email + "</td>" +
                  "</tr>" +
               "</tbody>" +
             "</table>" +
              "<h2>Wypożyczalnia</h3>" +
             "<table style=\"border: 1px solid black; padding: 5px; font-size: 24px; width: 100%; \">" +
              "<tbody>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Nazwa:</td>" +
                      "<td>" + agency.Name + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Adres:</td>" +
                      "<td>" + agency.RentalAgencyAddress.Street + " " + agency.RentalAgencyAddress.Number + "<br>"
                      + agency.RentalAgencyAddress.ZIPCode + " " + agency.RentalAgencyAddress.City + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">NIP:</td>" +
                      "<td>" + agency.NIP + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Telefon:</td>" +
                      "<td>" + agency.Phone1 + "</td>" +
                  "</tr>" +
                  "<tr>" +
                      "<td style=\"width:40%;\">Email:</td>" +
                      "<td>" + agency.Email1 + "</td>" +
                  "</tr>" +
              "</tbody>" +
             "</table>"
             ;

            HtmlToPdf converter = new HtmlToPdf();


            converter.Options.PdfPageSize = PdfPageSize.A4;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
            converter.Options.MarginLeft = 20;
            converter.Options.MarginRight = 20;
            converter.Options.MarginTop = 30;
            converter.Options.MarginBottom = 30;

            PdfDocument doc = converter.ConvertHtmlString(htmlcode);
            byte[] pdf = doc.Save();
            doc.Close();

            return File(
                    pdf,
                    "application/pdf",
                    "Potwierdzenie.pdf"
                );
        }

        private bool RentalVehicleExists(int id)
        {
            return _context.RentalVehicles.Any(e => e.RentalVehicleID == id);
        }
    }
}
