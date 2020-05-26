using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.WWW.Controllers.Abstract;
using Rental.WWW.Models;

namespace Rental.WWW.Controllers
{
    public class HomeController : BasicAbstractController
    {
        protected readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        : base(context, userManager)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Klient")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult DlaAdmina()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
