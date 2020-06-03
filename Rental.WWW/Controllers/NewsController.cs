using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.Data.Data.Rental;
using Rental.WWW.Controllers.Abstract;

namespace Rental.WWW.Controllers
{
    public class NewsController : BasicAbstractController
    {
        protected readonly ILogger<HomeController> _logger;

        public NewsController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        : base(context, userManager)
        {
            _logger = logger;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.News.Include(i => i.SenderUser).OrderBy(o => o.Create).ToListAsync());
        }
        public async Task<IActionResult> ReadItem(int? id)
        {
            var toRead = await _context.News.Include(i => i.SenderUser).FirstOrDefaultAsync(w => w.NewsID == id);
            if (toRead == null)
                return View("Index");
            else
                return View(toRead);
        }
    }
}