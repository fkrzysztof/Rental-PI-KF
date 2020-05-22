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
using Rental.Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    public class NewsController : BasicControllerAbstract
    {
        public NewsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        : base(context, userManager)
        {
        }

        // GET: News
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.News.Include(n => n.SenderUser);
            ViewBag.ItemCollection = await applicationDbContext.ToListAsync();
            return View();
        }

        // GET: News/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.SenderUser)
                .FirstOrDefaultAsync(m => m.NewsID == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }


        // POST: News/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NewsID,Topic,NewsContent")] News news)
        {
            if (ModelState.IsValid)
            {
                news.UserID = GetUser().Id;
                news.Create = DateTime.Now;
                _context.Add(news);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", news.UserID);
            return View(news);
        }

        // POST: News/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NewsID,Topic,NewsContent")] News news)
        {
            if (id != news.NewsID)
            {
                return NotFound();
            }
            
            news.UserID = GetUser().Id;
            news.Create = DateTime.Now;
            
            if (ModelState.IsValid)
            {


                try
                {
                    _context.Update(news);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.NewsID))
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
            return View(news);
        }


        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.NewsID == id);
        }

        public ActionResult GetTopNews()
        {
            var query = _context.News
                .OrderBy(o => o.Create)
                .Select(s => new { topic = s.Topic, newsContent = s.NewsContent }).Take(4).ToList();

            return Json(query);
        }

    }
}
