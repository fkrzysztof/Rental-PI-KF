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
    public class AirConditioningsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirConditioningsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AirConditionings
        public async Task<IActionResult> Index()
        {
            return View(await _context.AirConditionings.ToListAsync());
        }

        // GET: AirConditionings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airConditioning = await _context.AirConditionings
                .FirstOrDefaultAsync(m => m.AirConditioningID == id);
            if (airConditioning == null)
            {
                return NotFound();
            }

            return View(airConditioning);
        }

        // GET: AirConditionings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AirConditionings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AirConditioningID,Type,IsActive")] AirConditioning airConditioning)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airConditioning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airConditioning);
        }

        // GET: AirConditionings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airConditioning = await _context.AirConditionings.FindAsync(id);
            if (airConditioning == null)
            {
                return NotFound();
            }
            return View(airConditioning);
        }

        // POST: AirConditionings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AirConditioningID,Type,IsActive")] AirConditioning airConditioning)
        {
            if (id != airConditioning.AirConditioningID)
            {
                return NotFound();
            }

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
            return View(airConditioning);
        }

        // GET: AirConditionings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airConditioning = await _context.AirConditionings
                .FirstOrDefaultAsync(m => m.AirConditioningID == id);
            if (airConditioning == null)
            {
                return NotFound();
            }

            return View(airConditioning);
        }

        // POST: AirConditionings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var airConditioning = await _context.AirConditionings.FindAsync(id);
            _context.AirConditionings.Remove(airConditioning);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirConditioningExists(int id)
        {
            return _context.AirConditionings.Any(e => e.AirConditioningID == id);
        }
    }
}
