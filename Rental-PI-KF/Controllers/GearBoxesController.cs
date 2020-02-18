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
        public async Task<IActionResult> Index()
        {
            return View(await _context.GearBoxes.ToListAsync());
        }

        // GET: GearBoxes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gearBox = await _context.GearBoxes
                .FirstOrDefaultAsync(m => m.GearBoxID == id);
            if (gearBox == null)
            {
                return NotFound();
            }

            return View(gearBox);
        }

        // GET: GearBoxes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GearBoxes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GearBoxID,Name,Description,IsActive")] GearBox gearBox)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gearBox);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gearBox);
        }

        // GET: GearBoxes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gearBox = await _context.GearBoxes.FindAsync(id);
            if (gearBox == null)
            {
                return NotFound();
            }
            return View(gearBox);
        }

        // POST: GearBoxes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GearBoxID,Name,Description,IsActive")] GearBox gearBox)
        {
            if (id != gearBox.GearBoxID)
            {
                return NotFound();
            }

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
            return View(gearBox);
        }

        // GET: GearBoxes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gearBox = await _context.GearBoxes
                .FirstOrDefaultAsync(m => m.GearBoxID == id);
            if (gearBox == null)
            {
                return NotFound();
            }

            return View(gearBox);
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
