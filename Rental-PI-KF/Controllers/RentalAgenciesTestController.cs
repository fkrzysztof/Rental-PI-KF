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
    public class RentalAgenciesTestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalAgenciesTestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentalAgenciesTest
        public async Task<IActionResult> Index()
        {
            return View(await _context.RentalAgencies.ToListAsync());
        }

        // GET: RentalAgenciesTest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalAgency = await _context.RentalAgencies
                .FirstOrDefaultAsync(m => m.RentalAgencyID == id);
            if (rentalAgency == null)
            {
                return NotFound();
            }

            return View(rentalAgency);
        }

        // GET: RentalAgenciesTest/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RentalAgenciesTest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalAgencyID,ContactPerson,Number,BranchOfCompany,Name,Phone1,Phone2,Email1,Email2,DateAdded,Annotation,IsActive,REGON,NIP")] RentalAgency rentalAgency)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalAgency);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentalAgency);
        }

        // GET: RentalAgenciesTest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalAgency = await _context.RentalAgencies.FindAsync(id);
            if (rentalAgency == null)
            {
                return NotFound();
            }
            return View(rentalAgency);
        }

        // POST: RentalAgenciesTest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalAgencyID,ContactPerson,Number,BranchOfCompany,Name,Phone1,Phone2,Email1,Email2,DateAdded,Annotation,IsActive,REGON,NIP")] RentalAgency rentalAgency)
        {
            if (id != rentalAgency.RentalAgencyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalAgency);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalAgencyExists(rentalAgency.RentalAgencyID))
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
            return View(rentalAgency);
        }

        // GET: RentalAgenciesTest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalAgency = await _context.RentalAgencies
                .FirstOrDefaultAsync(m => m.RentalAgencyID == id);
            if (rentalAgency == null)
            {
                return NotFound();
            }

            return View(rentalAgency);
        }

        // POST: RentalAgenciesTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalAgency = await _context.RentalAgencies.FindAsync(id);
            _context.RentalAgencies.Remove(rentalAgency);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalAgencyExists(int id)
        {
            return _context.RentalAgencies.Any(e => e.RentalAgencyID == id);
        }
    }
}
