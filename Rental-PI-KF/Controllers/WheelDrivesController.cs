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
        public async Task<IActionResult> Index()
        {
            return View(await _context.WheelDrives.ToListAsync());
        }

        // GET: WheelDrives/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wheelDrive = await _context.WheelDrives
                .FirstOrDefaultAsync(m => m.WheelDriveID == id);
            if (wheelDrive == null)
            {
                return NotFound();
            }

            return View(wheelDrive);
        }

        // GET: WheelDrives/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WheelDrives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WheelDriveID,Name,Description,IsActive")] WheelDrive wheelDrive)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wheelDrive);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wheelDrive);
        }

        // GET: WheelDrives/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wheelDrive = await _context.WheelDrives.FindAsync(id);
            if (wheelDrive == null)
            {
                return NotFound();
            }
            return View(wheelDrive);
        }

        // POST: WheelDrives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WheelDriveID,Name,Description,IsActive")] WheelDrive wheelDrive)
        {
            if (id != wheelDrive.WheelDriveID)
            {
                return NotFound();
            }

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
            return View(wheelDrive);
        }

        // GET: WheelDrives/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wheelDrive = await _context.WheelDrives
                .FirstOrDefaultAsync(m => m.WheelDriveID == id);
            if (wheelDrive == null)
            {
                return NotFound();
            }

            return View(wheelDrive);
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
