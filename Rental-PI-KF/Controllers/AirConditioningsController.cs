using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    public class AirConditioningsController : BasicControllerAbstract
    {
        public AirConditioningsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        : base(context, userManager)
        {
        }

        // GET: AirConditionings
        public async Task<IActionResult> Index(string search, bool? remove, string removeName)
        {
            var itemCollection = await _context.AirConditionings.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Type.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Type);
            ViewBag.Remove = remove;
            ViewBag.RemoveName = removeName;

            return View();
        }


        // POST: AirConditionings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AirConditioningID,Type")] AirConditioning airConditioning)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airConditioning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }


        // POST: AirConditionings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AirConditioningID,Type")] AirConditioning airConditioning)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airConditioning);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirConditioningExists(airConditioning.AirConditioningID))
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
            return View("Index");
        }


        // POST: AirConditionings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezult = await _context.AirConditionings.FirstOrDefaultAsync(f => f.AirConditioningID == id);

            if (rezult == null)
                return RedirectToAction(nameof(Index));

            if (await _context.Vehicles.FirstOrDefaultAsync(f => f.AirConditioningID == id) != null)
                return RedirectToAction(nameof(Index), new { remove = false, removeName = rezult.Type });

            _context.AirConditionings.Remove(rezult);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { remove = true, removeName = rezult.Type });
        }

        private bool AirConditioningExists(int id)
        {
            return _context.AirConditionings.Any(e => e.AirConditioningID == id);
        }
    }
}
