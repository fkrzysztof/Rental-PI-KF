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
    public class GearBoxesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GearBoxesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GearBoxes
        public async Task<IActionResult> Index(string search, bool? remove, string removeName)
        {
            var itemCollection = await _context.GearBoxes.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Name.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Name);
            ViewBag.Remove = remove;
            ViewBag.RemoveName = removeName;

            return View();
        }


        // POST: GearBoxes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GearBoxID,Name,Description")] GearBox gearBox)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gearBox);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }

        // POST: GearBoxes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GearBoxID,Name,Description")] GearBox gearBox)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gearBox);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GearBoxExists(gearBox.GearBoxID))
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

        // POST: GearBoxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezult = await _context.GearBoxes.FirstOrDefaultAsync(f => f.GearBoxID == id);
            if (rezult == null)
                return RedirectToAction(nameof(Index));
            if (await _context.Vehicles.FirstOrDefaultAsync(f => f.GearBoxID == id) != null)
                return RedirectToAction(nameof(Index), new { remove = false, removeName = rezult.Name });
            _context.GearBoxes.Remove(rezult);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { remove = true, removeName = rezult.Name });
        }

        private bool GearBoxExists(int id)
        {
            return _context.GearBoxes.Any(e => e.GearBoxID == id);
        }
    }
}
