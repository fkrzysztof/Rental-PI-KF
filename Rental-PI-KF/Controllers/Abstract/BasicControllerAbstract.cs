using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_Data.Data.Rental;
using System.Collections.Generic;
using System.Linq;

namespace Rental_PI_KF.Controllers.Abstract
{
    public class BasicControllerAbstract : Controller
    {
        
        protected readonly UserManager<ApplicationUser> _userManager;
        protected readonly ApplicationDbContext _context;
        public ApplicationUser user;

        //potrzebne do wprawidlowego wyswietlania menu
        //public List<GeneralType> _generalTypesList; 

        public BasicControllerAbstract(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public void GeneralTypeToMenu()
        {
            ViewBag.GeneralTypesList = _context.GeneralTypes.ToList();
        }

        public void UserProfile()
        {
            
            var id = _userManager.GetUserId(HttpContext.User);
            //List<ApplicationUser> users = _userManager.GetUsersInRoleAsync("Klient").Result.ToList();
            var user = _userManager.Users.FirstOrDefault(f => f.Id == id);
            //user = users.FirstOrDefault(f => f.Id == id);

            //var us = _userManager.Users;
            //us = user.FirstOrDefault(f => f.Id == id);
            //user.PasswordHash = null;

            //nie moze byc viewbagow - tylko do testow
            //ViewBag.Users = users;
            ViewBag.User = user;
            //ViewBag.Img = user.Image;
        }
    }
}
