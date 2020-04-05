using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{

    public class RoleController : BasicControllerAbstract
    {
      //  RoleManager<IdentityRole> _roleManager;

        public RoleController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        : base(context, userManager)
        {
     //       _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            //   var roles = _roleManager.Roles.ToList();
            //   return View(roles);
            //List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            //List<ApplicationUser> users =  _userManager.Users.ToList();

            //ViewBag.Users = users;

            //  tu moze bedzie dalsza czas ustawiania role ?

            return RedirectToAction("Customers");

        }

        public IActionResult Customers()
        {
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            return View(users);
        }

        public IActionResult Administrators()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View();
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if( user == null)
            {
                return View("NotFound");
            }

            return View(user);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
      //      await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
    }
}