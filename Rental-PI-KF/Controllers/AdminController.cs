using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Rental_PI_KF.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles= "Administrator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}