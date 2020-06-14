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
    public class MessagesController : BasicControllerAbstract
    {

        private readonly RoleManager<IdentityRole> _roleManager;

        public MessagesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        : base(context, userManager)
        {
            _roleManager = roleManager;
        }

        // GET: Admin
        public async Task<IActionResult> Index(string searchString)
        {
            ViewBag.Tite = "Wiadomosci przychodzące";
            
            var Messages = _context.Messages
                .Include(n => n.ReadMessages).Include(n => n.SenderUser)
                .Where(n => n.UserTypeName == GetUserRoleName() && n.IsActive == true && n.StartDate <= DateTime.Now &&
                n.ExpirationDate >= DateTime.Now && n.SenderUser.Id != GetUser().Id);

            ViewBag.Search = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                var searchResult = Messages.Where(w =>
                w.SenderUser.FirstName.Contains(searchString) ||
                w.SenderUser.LastName.Contains(searchString) ||
                w.Title.Contains(searchString) ||
                w.MessageContent.Contains(searchString)
                );
                return View(await searchResult.OrderByDescending(u => u.UpdatedDate).ToListAsync());
            }

            return View(await Messages.OrderByDescending(u => u.UpdatedDate).ToListAsync());
        }


        // GET: Moje
        public async Task<IActionResult> Own(string searchString)
        {
            var Messages = _context.Messages
                .Include(n => n.ReadMessages).Include(n => n.SenderUser)
                .Where(n => n.IsActive == true && n.SenderUser.Id == GetUser().Id);

            ViewBag.Search = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                var searchResult = Messages.Where(w =>
                w.SenderUser.FirstName.Contains(searchString) ||
                w.SenderUser.LastName.Contains(searchString) ||
                w.Title.Contains(searchString) ||
                w.MessageContent.Contains(searchString)
                );
            
                return View(await searchResult.OrderByDescending(u => u.StartDate).ToListAsync());
            }

            return View(await Messages.OrderByDescending(u => u.StartDate).ToListAsync());
        }

        // GET: Messages/Create
        public IActionResult Create()
        {
            ViewData["UserTypeName"] = new SelectList(_roleManager.Roles.Where(w => w.Name != "Zablokowani"), "Name", "Name");

            return View();
        }

        // POST: Messages/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Message message)
        {
            if (ModelState.IsValid)
            {
                message.AddedDate = DateTime.Now;
                message.UserID = GetUser().Id;
                message.UpdatedDate = message.AddedDate; 
                message.IsActive = true;

                _context.Add(message);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(message);
        }

        // GET: Messages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ShowMessage = await _context.Messages.Include(i => i.SenderUser).FirstOrDefaultAsync(m => m.MessageID == id);
            if (ShowMessage == null)
            {
                return NotFound();
            }

            ViewData["UserTypeName"] = new SelectList(_roleManager.Roles, "Name", "Name", ShowMessage.UserTypeName); 

            return View(ShowMessage);
        }

        // POST: Messages/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Message message)
        {
            if (id != message.MessageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    message.UpdatedDate = DateTime.Now;
                    message.IsActive = true;
                    _context.Update(message);

                    //do sprawdzenia ! mozliwa zamina na pobranie i zmiane pobranej wiadomosci

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(message.MessageID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }

            return View(message);
        }

        // GET: Messages/Details/5
        public async Task<IActionResult> OwnDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<string> userReaded = _context.ReadMessages
            .Where(w => w.MessageID == id && w.UserID != GetUser().Id).Select(s => s.UserID).ToList();

            List<ApplicationUser> userList = new List<ApplicationUser>();
            foreach (var item in userReaded)
            {
                userList.Add(_context.Users.FirstOrDefault(f => f.Id == item));
            }

            ViewBag.UserList = userList;

            var ShowMessage = await _context.Messages
                .Include(n => n.SenderUser)
                .FirstOrDefaultAsync(m => m.MessageID == id);

            if (ShowMessage == null)
            {
                return NotFound();
            }

            return View(ShowMessage);
        }

        // GET: Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //zmiana na przeczytana
            if (_context.ReadMessages.FirstOrDefault(f => f.MessageID == id && f.UserID == GetUser().Id) == null)
            {
                _context.ReadMessages.Add(
                    new ReadMessages
                    {
                        UserID = GetUser().Id,
                        MessageID = Convert.ToInt32(id)
                    });
            }

            await _context.SaveChangesAsync();
            
            var ShowMessage = await _context.Messages
                .Include(n => n.SenderUser)
                .FirstOrDefaultAsync(m => m.MessageID == id);

            if (ShowMessage == null)
            {
                return NotFound();
            }

            return View(ShowMessage);
        }


        // POST: Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var messageDelete = await _context.Messages.FindAsync(id);
            messageDelete.IsActive = false;
            await _context.SaveChangesAsync();

            return RedirectToAction("Own");
        }

        public async Task<IActionResult> Restore(int id)
        {
            var messageDelete = await _context.Messages.FindAsync(id);
            messageDelete.IsActive = true;
            await _context.SaveChangesAsync();

            return RedirectToAction("DeletedMessages");
        }


        // GET: Moje
        public async Task<IActionResult> DeletedMessages(string searchString)
        {
            var Messages = _context.Messages
                .Include(n => n.ReadMessages).Include(n => n.SenderUser)
                .Where(n => n.IsActive == false);

            ViewBag.Search = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                var searchResult = Messages.Where(w =>
                w.SenderUser.FirstName.Contains(searchString) ||
                w.SenderUser.LastName.Contains(searchString) ||
                w.Title.Contains(searchString) ||
                w.MessageContent.Contains(searchString)
                );

                return View(await searchResult.OrderByDescending(u => u.StartDate).ToListAsync());
            }

            return View(await Messages.OrderByDescending(u => u.StartDate).ToListAsync());
        }


        private bool NewsExists(int id)
        {
            return _context.Messages.Any(e => e.MessageID == id);
        }


        //JS licznik nieprzeczytanych wiadomosci
        public ActionResult GetMessagesCount()
        {
            var newMessages = _context.Messages
                .Where(w => w.UserTypeName == GetUserRoleName() &&
                    w.UserID != GetUser().Id &&
                    w.StartDate <= DateTime.Now &&
                    w.ExpirationDate >= DateTime.Now &&
                    w.ReadMessages.FirstOrDefault(f => f.UserID == GetUser().Id) == null).Count();
            return Json(newMessages);
        }
        
    }
}