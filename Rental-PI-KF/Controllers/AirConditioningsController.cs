﻿using System;
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
        public async Task<IActionResult> Index(string search)
        {
            var itemCollection = await _context.AirConditionings.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Type.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Type);
            return View();
        }


        // POST: AirConditionings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AirConditioningID,Type")] AirConditioning airConditioning)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airConditioning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }


        // POST: AirConditionings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AirConditioningID,Type")] AirConditioning airConditioning)
        {

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
            return View("Index");
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
