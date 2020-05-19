using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    [Authorize(Roles = "Administrator")]
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
            return RedirectToAction("Customers");
        }

        //Klient
        public IActionResult Customers(string search)
        {
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            ViewBag.UserRole = "Klient";
            ViewBag.Action = "Customers";
            if (search != null)
            {
              users =  users.Where(w =>
                    w.Fullname.Contains(search) ||
                    w.City.Contains(search) ||
                    w.Country.Contains(search) ||
                    w.Street.Contains(search) ||
                    w.PhoneNumber.Contains(search) ||
                    w.ZIPCode.Contains(search) ||
                    w.UserName.Contains(search)
                    ).ToList();
            }
            allUsers(users);

            return View("Index", users);
        }

        //Zablokowani
        public IActionResult BlockedUsers(string search)
        {
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Zablokowani").Result.ToList();
            ViewBag.UserRole = "Zablokowani";
            ViewBag.Action = "BlockedUsers";
            if (search != null)
            {
                users = users.Where(w =>
                     w.Fullname.Contains(search) ||
                     w.City.Contains(search) ||
                     w.Country.Contains(search) ||
                     w.Street.Contains(search) ||
                     w.PhoneNumber.Contains(search) ||
                     w.ZIPCode.Contains(search) ||
                     w.UserName.Contains(search)
                      ).ToList();
            }
            allUsers(users);

            return View("Index", users);
        }

        //Administrator
        public IActionResult Administrators(string search)
        {
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Administrator").Result.ToList();
            ViewBag.UserRole = "Administrator";
            ViewBag.Action = "Administrators";
            if (search != null)
            {
                users = users.Where(w =>
                     w.Fullname.Contains(search) ||
                     w.City.Contains(search) ||
                     w.Country.Contains(search) ||
                     w.Street.Contains(search) ||
                     w.PhoneNumber.Contains(search) ||
                     w.ZIPCode.Contains(search) ||
                     w.UserName.Contains(search)
                      ).ToList();
            }
            allUsers(users);

            return View("Index", users);
        }

        //Pracownik
        public IActionResult Employees(string search)
        {
            List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Pracownik").Result.ToList();
            ViewBag.UserRole = "Pracownik";
            ViewBag.Action = "Employees";
            if (search != null)
            {
                users = users.Where(w =>
                     w.Fullname.Contains(search) ||
                     w.City.Contains(search) ||
                     w.Country.Contains(search) ||
                     w.Street.Contains(search) ||
                     w.PhoneNumber.Contains(search) ||
                     w.ZIPCode.Contains(search) ||
                     w.UserName.Contains(search)
                      ).ToList();
            }
            allUsers(users);

            return View("Index", users);
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

        
        public async Task<IActionResult> Edit(string id, string actionLink)
        {
            var user = await _userManager.FindByIdAsync(id);
            if( user == null)
            {
                return View("NotFound");
            }
            var getUserRole = await _userManager.GetRolesAsync(user);
            //tutaj powinni byc wszyscy bo b uc moze bedie przypadek ze bedzie 2 role do jednego usera 1!!!!!!!!!!!!!
            var usersRole = _roleManager.Roles.Where(w => w.Name != "Zablokowani" && w.Name != getUserRole.First());
            //usuwam z listy aktualna role oraz zablokowanych uzytkownikow
            ViewBag.UsersRole = new SelectList(usersRole, "Name", "Name");
            Password pw = new Password();
            ViewBag.Password = pw;
            ViewBag.Action = actionLink;
            ViewBag.RoleNow = _userManager.GetRolesAsync(user).Result.First();

            var ra = _context.RentalAgencies.FirstOrDefault(f => f.RentalAgencyID == user.RentalAgencyID);
            var rentalAll = _context.RentalAgencies.Where(w => w.IsActive == true).ToList();
            //dodane do edycji RentalAgency
            //jesli uzytkownik posiada oddzial i istnieje taka RentalAgency 
            if (user.RentalAgencyID != null || ra != null)
            { 
                //w przypadku usuniecia odzialu 
                var name = ra.Name;
                if (ra.IsActive == false)
                {
                    name = name + " " + "usunieta";
                }
                ViewBag.AgencyName = name;
                var allButThis = rentalAll.Where(w => w.RentalAgencyID != user.RentalAgencyID);
                ViewBag.RentalAgencyItems = new SelectList(allButThis, "RentalAgencyID", "Name");
            }
            else
            {
                ViewBag.AgencyName = "Brak";
                ViewBag.RentalAgencyItems = new SelectList(rentalAll, "RentalAgencyID", "Name");
            }
            
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, ApplicationUser au, IFormFile file, string actionLink)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Edit");
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return View("NotFound");
            }
            else
            {
                //var emailUser = await _userManager.GetPhoneNumberAsync(user);
                //if (user.Email != au.Email)
                //{
                //var setEmailResult1 = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                    
                    var setEmailResult = await _userManager.SetEmailAsync(user, au.Email);
                    if (!setEmailResult.Succeeded)
                    {
                        var userId = await _userManager.GetUserIdAsync(user);
                        throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                    }
                    var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var ConfirmEmailRezult = await _userManager.ConfirmEmailAsync(user, emailToken);

                    var SetUserNameRezult = await _userManager.SetUserNameAsync(user, au.Email);
                    if (!SetUserNameRezult.Succeeded)
                    {
                        var userId = await _userManager.GetUserIdAsync(user);
                        throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                    }
                //}


                if (file != null)
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
                //user.Email = au.Email;
                user.PhoneNumber = au.PhoneNumber;
                user.Street = au.Street;
                user.Number = au.Number;
                user.Country = au.Country;
                user.City = au.City;
                user.ZIPCode = au.ZIPCode;

              var rezult =  await _userManager.UpdateAsync(user);

                if(rezult.Succeeded)
                {
                    return RedirectToAction(actionLink);
                }
            }

            return Content("Wystąpił błąd z edycją usera");
        }

        [HttpPost]
        public async Task<IActionResult> RentalAgencyChange(string id, int agencyID, string action)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return View("NotFound");
            }
            else
            {
                user.RentalAgencyID = agencyID;
                _context.Update(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(action);
            }
        }
        
            
        [HttpPost]
        public async Task<IActionResult> AddUser(string id, string roleName, string action)
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
                var rezult1 = await _userManager.AddToRoleAsync(user, roleName);
                if (rezult1.Succeeded)
                {
                    return RedirectToAction(action);
                }
                else
                {
                    return Content("wystapił błąd podaczas dodawania");
                }
            }
        }
        

        // *********************************** Tylko do konfiguracji ************************************
        [HttpPost]
        public async Task<IActionResult> Delete(string id, string action)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var rezultDelete = await _userManager.DeleteAsync(user);
                if (rezultDelete.Succeeded)
                    return RedirectToAction(action);
                else
                    return Content("Błąd podczas usuwania");
            }

            return Content("Nie ma takiego użytkownia");
        }
        public IActionResult Create()
        {
            return View(new IdentityRole());
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
        
        //END ******************************************************************************************

        private void allUsers(List<ApplicationUser> users)
        {
            //wszyscy
            List<ApplicationUser> userAll = _userManager.Users.ToList();
            //sparacja
            foreach (var itemUser in users)
            {
                if (userAll.Contains(itemUser))
                    userAll.Remove(itemUser);
            }
            ViewBag.UserAll = new SelectList(userAll, "Id", "Fullname");
        }
    }
}