using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.WWW.Controllers.Abstract;

namespace Rental.WWW.Controllers
{
    public class ContactController : BasicAbstractController
    {
        protected readonly ILogger<HomeController> _logger;

        public ContactController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        : base(context, userManager)
        {
            _logger = logger;
        }

        // GET: Contact
        public async Task<IActionResult> Index()
        {
            return View(await _context.RentalAgencies.Include(i => i.RentalAgencyAddress).Where(w => w.IsActive == true).ToListAsync());
        }
    }
}
