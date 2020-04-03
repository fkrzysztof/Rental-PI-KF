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
        public async Task<IActionResult> Index(string search)
        {
            var itemCollection = await _context.GearBoxes.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Name.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Name);
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
            var gearBox = await _context.GearBoxes.FindAsync(id);
            _context.GearBoxes.Remove(gearBox);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GearBoxExists(int id)
        {
            return _context.GearBoxes.Any(e => e.GearBoxID == id);
        }
    }
}
