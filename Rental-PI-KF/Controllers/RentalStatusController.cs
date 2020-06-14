using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    public class RentalStatusController : BasicControllerAbstract
    {
        public RentalStatusController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        : base(context, userManager)
        {
        }

        // GET: RentalStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.RentalStatuses.ToListAsync());
        }

        // GET: Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: RentalStatus/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalStatusID,Name,IsActive")] RentalStatus rentalStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentalStatus);
        }

        // POST: RentalStatus/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalStatusID,Name,IsActive")] RentalStatus rentalStatus)
        {
            if (id != rentalStatus.RentalStatusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalStatusExists(rentalStatus.RentalStatusID))
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
            return View(rentalStatus);
        }

        // POST: RentalStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalStatus = await _context.RentalStatuses.FindAsync(id);
            _context.RentalStatuses.Remove(rentalStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalStatusExists(int id)
        {
            return _context.RentalStatuses.Any(e => e.RentalStatusID == id);
        }
    }
}
