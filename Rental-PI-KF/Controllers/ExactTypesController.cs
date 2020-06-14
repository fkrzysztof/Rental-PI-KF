using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    public class ExactTypesController : BasicControllerAbstract
    {
        public ExactTypesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        : base(context, userManager)
        {
        }

        // GET: ExactTypes
        public async Task<IActionResult> Index(int? generalType, bool? remove, string removeName)
        {
            var applicationDbContext = await _context.ExactTypes.Include(e => e.GeneralType).ToListAsync();
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name");
            if(generalType != null)
            {
              applicationDbContext = applicationDbContext.Where(w => w.GeneralTypeID == generalType).ToList();
            }
            ViewBag.GeneralTypeCollection = applicationDbContext.OrderBy(o => o.GeneralType.Name).ThenBy(t => t.Name);
            ViewBag.Remove = remove;
            ViewBag.RemoveName = removeName;

            return View();
        }


        // POST: ExactTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExactTypeID,GeneralTypeID,Name,IsActive")] ExactType exactType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exactType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name");
            var applicationDbContext = _context.ExactTypes.Include(e => e.GeneralType);
            ViewBag.GeneralTypeCollection = applicationDbContext;
            return View("Index");
        }

        // POST: ExactTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("ExactTypeID,GeneralTypeID,Name")] ExactType exactType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exactType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExactTypeExists(exactType.ExactTypeID))
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
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name");
            var applicationDbContext = _context.ExactTypes.Include(e => e.GeneralType);
            ViewBag.GeneralTypeCollection = applicationDbContext;
            return View("Index");
        }

        // POST: ExactTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezult = await _context.ExactTypes.FirstOrDefaultAsync(f => f.ExactTypeID == id);
            if (rezult == null)
                return RedirectToAction(nameof(Index));
            if (await _context.Vehicles.FirstOrDefaultAsync(f => f.ExactTypeID == id) != null)
                return RedirectToAction(nameof(Index), new { remove = false, removeName = rezult.Name });
            _context.ExactTypes.Remove(rezult);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { remove = true, removeName = rezult.Name });
        }

        private bool ExactTypeExists(int id)
        {
            return _context.ExactTypes.Any(e => e.ExactTypeID == id);
        }
    }
}
