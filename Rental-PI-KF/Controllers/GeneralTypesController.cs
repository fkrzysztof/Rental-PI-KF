using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental_Data.Data.Rental;

namespace Rental_PI_KF.Controllers
{
    public class GeneralTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GeneralTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GeneralTypes
        public async Task<IActionResult> Index(string search)
        {
            var itemCollection = await _context.GeneralTypes.ToListAsync();
            if (search != null)
                 itemCollection = itemCollection.Where(w => w.Name.Contains(search)).ToList();
            ViewBag.ItemCollection = itemCollection.OrderBy(o => o.Name); ;
            return View();
        }

        // POST: GeneralTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GeneralTypeID,Name,IsActive")] GeneralType generalType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generalType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generalType);
        }


        // POST: GeneralTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("GeneralTypeID,Name")] GeneralType generalType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralTypeExists(generalType.GeneralTypeID))
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
            ViewBag.GeneralTypeCollection = _context.GeneralTypes;
            return View("Index");
        }


        // POST: GeneralTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var generalType = await _context.GeneralTypes.FindAsync(id);
            _context.GeneralTypes.Remove(generalType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralTypeExists(int id)
        {
            return _context.GeneralTypes.Any(e => e.GeneralTypeID == id);
        }
    }
}
