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
        public async Task<IActionResult> Index()
        {
            return View(await _context.EngineTypes.ToListAsync());
        }

        // GET: EngineTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engineType = await _context.EngineTypes
                .FirstOrDefaultAsync(m => m.EngineTypeID == id);
            if (engineType == null)
            {
                return NotFound();
            }

            return View(engineType);
        }

        // GET: EngineTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EngineTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EngineTypeID,Name,IsActive")] EngineType engineType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(engineType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(engineType);
        }

        // GET: EngineTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engineType = await _context.EngineTypes.FindAsync(id);
            if (engineType == null)
            {
                return NotFound();
            }
            return View(engineType);
        }

        // POST: EngineTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EngineTypeID,Name,IsActive")] EngineType engineType)
        {
            if (id != engineType.EngineTypeID)
            {
                return NotFound();
            }

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
            return View(engineType);
        }

        // GET: EngineTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engineType = await _context.EngineTypes
                .FirstOrDefaultAsync(m => m.EngineTypeID == id);
            if (engineType == null)
            {
                return NotFound();
            }

            return View(engineType);
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
