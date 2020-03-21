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
    public class RentalAgencyAddressesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalAgencyAddressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentalAgencyAddresses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RentalAgencyAddresses.Include(r => r.RentalAgency);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RentalAgencyAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalAgencyAddress = await _context.RentalAgencyAddresses
                .Include(r => r.RentalAgency)
                .FirstOrDefaultAsync(m => m.RentalAgencyAddressID == id);
            if (rentalAgencyAddress == null)
            {
                return NotFound();
            }

            return View(rentalAgencyAddress);
        }

        // GET: RentalAgencyAddresses/Create
        public IActionResult Create()
        {
            ViewData["RentalAgencyID"] = new SelectList(_context.RentalAgencies, "RentalAgencyID", "NIP");
            return View();
        }

        // POST: RentalAgencyAddresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalAgencyAddressID,Country,City,Street,Number,ZIPCode,IsActive,RentalAgencyID")] RentalAgencyAddress rentalAgencyAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalAgencyAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RentalAgencyID"] = new SelectList(_context.RentalAgencies, "RentalAgencyID", "NIP", rentalAgencyAddress.RentalAgencyID);
            return View(rentalAgencyAddress);
        }

        // GET: RentalAgencyAddresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalAgencyAddress = await _context.RentalAgencyAddresses.FindAsync(id);
            if (rentalAgencyAddress == null)
            {
                return NotFound();
            }
            ViewData["RentalAgencyID"] = new SelectList(_context.RentalAgencies, "RentalAgencyID", "NIP", rentalAgencyAddress.RentalAgencyID);
            return View(rentalAgencyAddress);
        }

        // POST: RentalAgencyAddresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalAgencyAddressID,Country,City,Street,Number,ZIPCode,IsActive,RentalAgencyID")] RentalAgencyAddress rentalAgencyAddress)
        {
            if (id != rentalAgencyAddress.RentalAgencyAddressID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalAgencyAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalAgencyAddressExists(rentalAgencyAddress.RentalAgencyAddressID))
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
            ViewData["RentalAgencyID"] = new SelectList(_context.RentalAgencies, "RentalAgencyID", "NIP", rentalAgencyAddress.RentalAgencyID);
            return View(rentalAgencyAddress);
        }

        // GET: RentalAgencyAddresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalAgencyAddress = await _context.RentalAgencyAddresses
                .Include(r => r.RentalAgency)
                .FirstOrDefaultAsync(m => m.RentalAgencyAddressID == id);
            if (rentalAgencyAddress == null)
            {
                return NotFound();
            }

            return View(rentalAgencyAddress);
        }

        // POST: RentalAgencyAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalAgencyAddress = await _context.RentalAgencyAddresses.FindAsync(id);
            _context.RentalAgencyAddresses.Remove(rentalAgencyAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalAgencyAddressExists(int id)
        {
            return _context.RentalAgencyAddresses.Any(e => e.RentalAgencyAddressID == id);
        }
    }
}
