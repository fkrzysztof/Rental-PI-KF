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
        public async Task<IActionResult> Index(string search, bool? remove, string removeName)
        {
            var itemCollection = await _context.EquipmentNames.ToListAsync();
            if (search != null)
                itemCollection = itemCollection.Where(w => w.Name.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Name);
            ViewBag.Remove = remove;
            ViewBag.RemoveName = removeName;

            return View();
        }


        // POST: EquipmentNames/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EquipmentNameID,Name")] EquipmentName equipmentName)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipmentName);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }


        // POST: EquipmentNames/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EquipmentNameID,Name")] EquipmentName equipmentName)
        {
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
            return View("Index");
        }

        // POST: EquipmentNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezult = await _context.EquipmentNames.FirstOrDefaultAsync(f => f.EquipmentNameID == id);
            if (rezult == null)
                return RedirectToAction(nameof(Index));
            if (await _context.Equipment.FirstOrDefaultAsync(f => f.EquipmentNameID == id) != null)
                return RedirectToAction(nameof(Index), new { remove = false, removeName = rezult.Name });
            _context.EquipmentNames.Remove(rezult);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { remove = true, removeName = rezult.Name });
        }

        private bool EquipmentNameExists(int id)
        {
            return _context.EquipmentNames.Any(e => e.EquipmentNameID == id);
        }
    }
}
