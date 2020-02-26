using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Data.Data.Rental;

namespace Rental_PI_KF.Controllers
{
    public class EquipmentNamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EquipmentNamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EquipmentNames
        public async Task<IActionResult> Index()
        {
            return View(await _context.EquipmentNames.ToListAsync());
        }

        // GET: EquipmentNames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentName = await _context.EquipmentNames
                .FirstOrDefaultAsync(m => m.EquipmentNameID == id);
            if (equipmentName == null)
            {
                return NotFound();
            }

            return View(equipmentName);
        }

        // GET: EquipmentNames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EquipmentNames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EquipmentNameID,Name,IsActive")] EquipmentName equipmentName)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipmentName);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipmentName);
        }

        // GET: EquipmentNames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentName = await _context.EquipmentNames.FindAsync(id);
            if (equipmentName == null)
            {
                return NotFound();
            }
            return View(equipmentName);
        }

        // POST: EquipmentNames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EquipmentNameID,Name,IsActive")] EquipmentName equipmentName)
        {
            if (id != equipmentName.EquipmentNameID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentName);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentNameExists(equipmentName.EquipmentNameID))
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
            return View(equipmentName);
        }

        // GET: EquipmentNames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentName = await _context.EquipmentNames
                .FirstOrDefaultAsync(m => m.EquipmentNameID == id);
            if (equipmentName == null)
            {
                return NotFound();
            }

            return View(equipmentName);
        }

        // POST: EquipmentNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentName = await _context.EquipmentNames.FindAsync(id);
            _context.EquipmentNames.Remove(equipmentName);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentNameExists(int id)
        {
            return _context.EquipmentNames.Any(e => e.EquipmentNameID == id);
        }
    }
}
