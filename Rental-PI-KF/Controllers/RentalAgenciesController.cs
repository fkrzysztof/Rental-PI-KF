using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental_Data.Data.Rental;

namespace Rental_PI_KF.Controllers
{
    public class RentalAgenciesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalAgenciesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentalAgencies
        public async Task<IActionResult> Index() => View(await _context.RentalAgencies.Include(i => i.RentalAgencyAddress).ToListAsync());

        // GET: CREATE
        public IActionResult Create() => View();


        // POST: RentalAgencies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalAgencyID,ContactPerson,Number,Name,Phone1,Phone2,Email1,Email2,Annotation,REGON,NIP")] RentalAgency rentalAgency,
                                                [Bind("RentalAgencyAddressID,Country,City,Street,Number,ZIPCode")] RentalAgencyAddress rentalAgencyAddress)
        {
            if (ModelState.IsValid)
            {
                rentalAgency.IsActive = true;
                rentalAgencyAddress.RentalAgency = rentalAgency;
                _context.Add(rentalAgencyAddress);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentalAgency);
        }

        // GET: RentalAgencies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var rentalAgency = await _context.RentalAgencies.Include(i => i.RentalAgencyAddress).FirstOrDefaultAsync(f => f.RentalAgencyID == id);
            if (rentalAgency == null)
            {
                return NotFound();
            }

            return View(rentalAgency);
        }


        ////POST: RentalAgencies/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int? id, [Bind("RentalAgencyID,ContactPerson,Number,Name,Phone1,Phone2,Email1,Email2,Annotation,REGON,NIP")] RentalAgency rentalAgency,
        //                                               [Bind("RentalAgencyAddressID,Country,City,Street,Number,ZIPCode")] RentalAgencyAddress rentalAgencyAddress)
        ////public async Task<IActionResult> Edit(int? id, RentalAgency rentalAgency)
        //{
        //    rentalAgencyAddress.RentalAgencyID = id;

        //    if (ModelState.IsValid)
        //    {
        //         _context.Update(rentalAgencyAddress);
        //        _context.Update(rentalAgency);

        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    //ViewBag.RentalAgencyAddress = _context.RentalAgencyAddresses.FirstOrDefault(f => f.RentalAgencyID == rentalAgency.RentalAgencyID);
        //    return View(rentalAgency);
        //}



        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRentalAgency(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ra = await _context.RentalAgencies.FirstOrDefaultAsync(f => f.RentalAgencyID == id);

            //if (ra.RentalAgencyAddress == null)
            //{
            //    _context.Add(new RentalAgencyAddress() { RentalAgencyID = id });
            //    await _context.SaveChangesAsync();
            //}
            

            var RentalAgencyToUpdate = await _context.RentalAgencies
                .Include(i => i.RentalAgencyAddress)
                .FirstOrDefaultAsync(m => m.RentalAgencyID == id);

            if (await TryUpdateModelAsync<RentalAgency>(
                RentalAgencyToUpdate,
                "",
                i => i.Name, i => i.NIP, i => i.REGON, i => i.RentalAgencyAddress))
            {
                //if (RentalAgencyToUpdate.RentalAgencyAddress.RentalAgencyAddressID == null)
                //{
                //    RentalAgencyToUpdate.RentalAgencyAddress = null;
                //}
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            //UpdateInstructorCourses(selectedCourses, instructorToUpdate);
            //PopulateAssignedCourseData(instructorToUpdate);
            return View(RentalAgencyToUpdate);
        }








        // POST: RentalAgencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalAgency = await _context.RentalAgencies.FindAsync(id);
            rentalAgency.IsActive = false;
            _context.Update(rentalAgency);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalAgencyExists(int id)
        {
            return _context.RentalAgencies.Any(e => e.RentalAgencyID == id);
        }
    }
}
