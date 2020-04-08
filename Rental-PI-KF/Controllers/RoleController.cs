using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{

    public class RoleController : BasicControllerAbstract
    {
        RoleManager<IdentityRole> _roleManager;

        public RoleController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        : base(context, userManager)
        {
            _roleManager = roleManager;
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
            ViewBag.UserRole = "Klient";


            return View(users);
        }

        public IActionResult Administrators()
        {
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Administrator").Result.ToList();
            var usersRole = _roleManager.Roles.ToList();
            ViewBag.UserRole = "Administrator";
            List<ApplicationUser> userAll = _userManager.Users.ToList();
            ViewBag.UserAll = new SelectList(userAll, "Id", "Fullname");

            return View(users);
        }

        public IActionResult Employees()
        {
            //do poprawy ALL user bez tych co sa ju zna liscie !!!!
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Pracownik").Result.ToList();
            List<ApplicationUser> userAll = _userManager.Users.ToList();
            ViewBag.UserAll = new SelectList( userAll, "Id", "Fullname");
            

            ViewBag.UserRole = "Pracownik";

            return View(users);
        }
        
        [HttpPost]
        public async Task<IActionResult> ResetPassword(string id,Password pw)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user != null)
            {
                string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                var rezult = await _userManager.ResetPasswordAsync(user, resetToken, pw.PasswordNew);
                if(rezult.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var error in rezult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(user);
            
        }

        
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if( user == null)
            {
                return View("NotFound");
            }
            var usersRole = _roleManager.Roles.ToList();
            ViewBag.UsersRole = new SelectList(usersRole, "Name", "Name");
            Password pw = new Password();
            ViewBag.Password = pw;


            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, ApplicationUser au, IFormFile file)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return View("NotFound");
            }
            else
            {
                if(file != null)
                { 
                    int w = 100;
                    int h = 100;

                    var stream = new MemoryStream();
                    await file.CopyToAsync(stream);
                    var image = Image.FromStream(stream);
                    Image imageR = ImageResize.ScaleAndCrop(image, w, h);
                    var streamToReturn = new MemoryStream();
                    imageR.Save(streamToReturn, image.RawFormat);

                    user.Image = streamToReturn.ToArray();
                }

                user.FirstName = au.FirstName;
                user.LastName = au.LastName;
                user.Email = au.Email;
                user.Phone = au.Phone;
                user.Street = au.Street;
                user.Number = au.Number;
                user.Country = au.Country;
                user.City = au.City;
                user.ZIPCode = au.ZIPCode;

              var rezult =  await _userManager.UpdateAsync(user);

                if(rezult.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Edit");
        }


        [HttpPost]
        public async Task<IActionResult> EditRole(string id, string roleName)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return View("NotFound");
            }
            else
            {
               var roleToRemove = _userManager.GetRolesAsync(user).Result.First();
               var remove = _userManager.RemoveFromRoleAsync(user, roleToRemove);
               var add = _userManager.AddToRoleAsync(user, roleName);
                //if (remove.Result.Succeeded && add.Result.Succeeded)
                if (add.Result.Succeeded)
                {
                   return RedirectToAction("Index");
                }
            }
            return Content("Coś poszło nie tak..");
        }


        [HttpPost]
        public async Task<IActionResult> AddUser(string id, string roleName)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return View("NotFound");
            }
            else
            {
                var roleOld = _userManager.GetRolesAsync(user).Result.ToList();
                foreach (var item in roleOld)
                {
                   var rezult2 = await _userManager.RemoveFromRoleAsync(user, item);
                    if (rezult2.Succeeded)
                        continue;
                    else
                        return Content("w petli jest problem");
                }
                //var rezult2 = await _userManager.RemoveFromRoleAsync(user, roleName);
                var rezult1 = await _userManager.AddToRoleAsync(user, roleName);
              if (rezult1.Succeeded)
              {
                    //nie moze wracac do indexu!!!!
                    return RedirectToAction("Index");
              }
              else
              {
                    return Content("wystapił błąd podaczas dodawania");
              }
            }
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
      //      await _roleManager.CreateAsync(role);
            
        //    _userManager.
            
            return RedirectToAction("Index");
        }
    }
}