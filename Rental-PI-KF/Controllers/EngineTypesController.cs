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
        public async Task<IActionResult> Index(string search)
        {
            var itemCollection = await _context.EngineTypes.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Name.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Name);
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
            var engineType = await _context.EngineTypes.FindAsync(id);
            _context.EngineTypes.Remove(engineType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EngineTypeExists(int id)
        {
            return _context.EngineTypes.Any(e => e.EngineTypeID == id);
        }
    }
}
