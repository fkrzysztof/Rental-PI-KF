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
    public class GeneralTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GeneralTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GeneralTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.GeneralTypes.ToListAsync());
        }

        // GET: GeneralTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalType = await _context.GeneralTypes
                .FirstOrDefaultAsync(m => m.GeneralTypeID == id);
            if (generalType == null)
            {
                return NotFound();
            }

            return View(generalType);
        }

        // GET: GeneralTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneralTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GeneralTypeID,Name,IsActive")] GeneralType generalType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generalType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generalType);
        }

        // GET: GeneralTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalType = await _context.GeneralTypes.FindAsync(id);
            if (generalType == null)
            {
                return NotFound();
            }
            return View(generalType);
        }

        // POST: GeneralTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GeneralTypeID,Name,IsActive")] GeneralType generalType)
        {
            if (id != generalType.GeneralTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralTypeExists(generalType.GeneralTypeID))
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
            return View(generalType);
        }

        // GET: GeneralTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalType = await _context.GeneralTypes
                .FirstOrDefaultAsync(m => m.GeneralTypeID == id);
            if (generalType == null)
            {
                return NotFound();
            }

            return View(generalType);
        }

        // POST: GeneralTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var generalType = await _context.GeneralTypes.FindAsync(id);
            _context.GeneralTypes.Remove(generalType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralTypeExists(int id)
        {
            return _context.GeneralTypes.Any(e => e.GeneralTypeID == id);
        }
    }
}
