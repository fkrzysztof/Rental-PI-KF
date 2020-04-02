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
        public async Task<IActionResult> Index(int? generalType)
        {
            var applicationDbContext = await _context.ExactTypes.Include(e => e.GeneralType).ToListAsync();
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name");
            if(generalType != null)
            {
              applicationDbContext = applicationDbContext.Where(w => w.GeneralTypeID == generalType).ToList();
            }
            ViewBag.GeneralTypeCollection = applicationDbContext;

            return View();
        }


        // POST: ExactTypes/Create
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
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name");
            var applicationDbContext = _context.ExactTypes.Include(e => e.GeneralType);
            ViewBag.GeneralTypeCollection = applicationDbContext;
            return View("Index");
        }

        // GET: ExactTypes/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var exactType = await _context.ExactTypes.FindAsync(id);
        //    if (exactType == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", exactType.GeneralTypeID);
        //    return View(exactType);
        //}

        // POST: ExactTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("ExactTypeID,GeneralTypeID,Name")] ExactType exactType)
        {
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
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name");
            var applicationDbContext = _context.ExactTypes.Include(e => e.GeneralType);
            ViewBag.GeneralTypeCollection = applicationDbContext;
            return View("Index");
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
