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
    public class WheelDrivesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WheelDrivesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WheelDrives
        public async Task<IActionResult> Index(string search)
        {
            var itemCollection = await _context.WheelDrives.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Name.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Name);
            return View();
        }


        // POST: WheelDrives/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WheelDriveID,Name,Description")] WheelDrive wheelDrive)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wheelDrive);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }


        // POST: WheelDrives/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WheelDriveID,Name,Description")] WheelDrive wheelDrive)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wheelDrive);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WheelDriveExists(wheelDrive.WheelDriveID))
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


        // POST: WheelDrives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wheelDrive = await _context.WheelDrives.FindAsync(id);
            _context.WheelDrives.Remove(wheelDrive);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WheelDriveExists(int id)
        {
            return _context.WheelDrives.Any(e => e.WheelDriveID == id);
        }
    }
}
