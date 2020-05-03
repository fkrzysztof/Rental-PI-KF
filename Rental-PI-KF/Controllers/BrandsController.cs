using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    public class BrandsController : BasicControllerAbstract
    {
        public BrandsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        : base(context, userManager)
        {
        }

        // GET: Brands
        public async Task<IActionResult> Index(string search, bool? remove, string removeName)
        {
            var itemCollection = await _context.Brands.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Name.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Name);
            ViewBag.Remove = remove;
            ViewBag.RemoveName = removeName;

            return View();
        }


        // POST: Brands/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrandID,Name,IsActive")] Brand brand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }


        // POST: Brands/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("BrandID,Name")] Brand brand)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandExists(brand.BrandID))
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
            return View(brand);
        }


        // POST: Brands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezult = await _context.Brands.FirstOrDefaultAsync(f => f.BrandID == id);
            if (rezult == null)
                return RedirectToAction(nameof(Index));
            if (await _context.Vehicles.FirstOrDefaultAsync(f => f.BrandID == id) != null || await _context.VehicleModels.FirstOrDefaultAsync(f => f.BrandID == id) != null)
                return RedirectToAction(nameof(Index), new { remove = false, removeName = rezult.Name });
            _context.Brands.Remove(rezult);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { remove = true, removeName = rezult.Name });
        }


        private bool BrandExists(int id)
        {
            return _context.Brands.Any(e => e.BrandID == id);
        }
    }
}
