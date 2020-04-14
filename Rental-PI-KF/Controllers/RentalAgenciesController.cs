using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental_Data.Data.Rental;

namespace Rental_PI_KF.Controllers
{
    public class RentalAgenciesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalAgenciesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentalAgencies
        public async Task<IActionResult> Index()
        {
            ViewBag.RentalAgencyAddress = new RentalAgencyAddress();
            return View(await _context.RentalAgencies.ToListAsync());
        }

        // GET: CREATE
        public IActionResult Create() => View();




        // POST: RentalAgencies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalAgencyID,ContactPerson,Number,Name,Phone1,Phone2,Email1,Email2,Annotation,REGON,NIP")] RentalAgency rentalAgency,
                                                [Bind("RentalAgencyAddressID,Country,City,Street,Number,ZIPCode")] RentalAgencyAddress rentalAgencyAddress)
        {
            if (ModelState.IsValid)
            {
                rentalAgency.IsActive = true;
                rentalAgencyAddress.RentalAgency = rentalAgency;
                _context.Add(rentalAgencyAddress);
 
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentalAgency);
        }

        // GET: RentalAgencies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var rentalAgency = await _context.RentalAgencies.FirstOrDefaultAsync();
            if (rentalAgency == null)
            {
                return NotFound();
            }
            ViewBag.RentalAgencyAddress = _context.RentalAgencyAddresses.FirstOrDefault(f => f.RentalAgencyID == id);

            return View(rentalAgency);
        }

        // Sprawdzi w get i post czy jest ok w validacji !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // zmienic update! 


        // POST: RentalAgencies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("RentalAgencyID,ContactPerson,Number,Name,Phone1,Phone2,Email1,Email2,Annotation,REGON,NIP")] RentalAgency rentalAgency,
                                                [Bind("RentalAgencyAddressID,Country,City,Street,Number,ZIPCode")] RentalAgencyAddress rentalAgencyAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Update(rentalAgency);
                _context.Update(rentalAgencyAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.RentalAgencyAddress = _context.RentalAgencyAddresses.FirstOrDefault(f => f.RentalAgencyID == rentalAgency.RentalAgencyID);
            return View(rentalAgency);
        }

        // POST: RentalAgencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalAgency = await _context.RentalAgencies.FindAsync(id);
            rentalAgency.IsActive = false;
            _context.Update(rentalAgency);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalAgencyExists(int id)
        {
            return _context.RentalAgencies.Any(e => e.RentalAgencyID == id);
        }
    }
}
