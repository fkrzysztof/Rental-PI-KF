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
    public class EngineTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EngineTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EngineTypes
        public async Task<IActionResult> Index(string search, bool? remove, string removeName)
        {
            var itemCollection = await _context.EngineTypes.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Name.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Name);
            ViewBag.Remove = remove;
            ViewBag.RemoveName = removeName;

            return View();
        }


        // POST: EngineTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EngineTypeID,Name")] EngineType engineType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(engineType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }

        // POST: EngineTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EngineTypeID,Name")] EngineType engineType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(engineType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EngineTypeExists(engineType.EngineTypeID))
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

        // POST: EngineTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezult = await _context.EngineTypes.FirstOrDefaultAsync(f => f.EngineTypeID == id);
            if (rezult == null)
                return RedirectToAction(nameof(Index));
            if (await _context.Vehicles.FirstOrDefaultAsync(f => f.EngineTypeID == id) != null)
                return RedirectToAction(nameof(Index), new { remove = false, removeName = rezult.Name });
            _context.EngineTypes.Remove(rezult);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { remove = true, removeName = rezult.Name });
        }

        private bool EngineTypeExists(int id)
        {
            return _context.EngineTypes.Any(e => e.EngineTypeID == id);
        }
    }
}
