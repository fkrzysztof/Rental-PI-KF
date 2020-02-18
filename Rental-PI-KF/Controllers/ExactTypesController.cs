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
    public class ExactTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExactTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExactTypes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ExactTypes.Include(e => e.GeneralType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ExactTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exactType = await _context.ExactTypes
                .Include(e => e.GeneralType)
                .FirstOrDefaultAsync(m => m.ExactTypeID == id);
            if (exactType == null)
            {
                return NotFound();
            }

            return View(exactType);
        }

        // GET: ExactTypes/Create
        public IActionResult Create()
        {
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID");
            return View();
        }

        // POST: ExactTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", exactType.GeneralTypeID);
            return View(exactType);
        }

        // GET: ExactTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exactType = await _context.ExactTypes.FindAsync(id);
            if (exactType == null)
            {
                return NotFound();
            }
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", exactType.GeneralTypeID);
            return View(exactType);
        }

        // POST: ExactTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExactTypeID,GeneralTypeID,Name,IsActive")] ExactType exactType)
        {
            if (id != exactType.ExactTypeID)
            {
                return NotFound();
            }

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
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", exactType.GeneralTypeID);
            return View(exactType);
        }

        // GET: ExactTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exactType = await _context.ExactTypes
                .Include(e => e.GeneralType)
                .FirstOrDefaultAsync(m => m.ExactTypeID == id);
            if (exactType == null)
            {
                return NotFound();
            }

            return View(exactType);
        }

        // POST: ExactTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exactType = await _context.ExactTypes.FindAsync(id);
            _context.ExactTypes.Remove(exactType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExactTypeExists(int id)
        {
            return _context.ExactTypes.Any(e => e.ExactTypeID == id);
        }
    }
}
