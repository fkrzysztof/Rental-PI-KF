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
using Rental_PI_KF.Controllers.Abstract;
using Rental_PI_KF.Models;

namespace Rental_PI_KF.Controllers
{
    [Authorize]
    public class HomeController : BasicControllerAbstract
    {
        protected readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        : base(context, userManager)
        {
            _logger = logger;

        }

        //private void ImgProfile()
        //{
        //    var id = _userManager.GetUserId(HttpContext.User);
        //    var us = _userManager.Users;
        //    var u = us.FirstOrDefault(f => f.Id == id);
        //    ViewBag.Img = u.Image;
        //}

        public IActionResult Index()
        {
            UserProfile();
            GeneralTypeToMenu();

            //var u = _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User));

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
