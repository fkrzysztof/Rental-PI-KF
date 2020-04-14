using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;

namespace Rental_PI_KF.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        protected readonly ApplicationDbContext _context;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string Name { get; set; }

            [Display(Name ="Imię")]
            public string FistNane { get; set; }
            
            [Display(Name ="Nazwisko")]
            public string LastName { get; set; }

            //dodane


            [Display(Name = "Zdjęcie")]
            public byte[]? Image { get; set; }

            [Display(Name = "Kraj")]
            public string Country { get; set; }

            [Display(Name = "Miasto")]
            public string City { get; set; }

            [Display(Name = "Ulica")]
            public string Street { get; set; }

            [Display(Name = "Numer")]
            public string Number { get; set; }

            [Display(Name = "Kod")]
            public string ZIPCode { get; set; }
            
            [Display(Name = "Telefon")]
            public string Phone { get; set; }

            [Display(Name = "Oddział")]
            public int? RentalAgencyID { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ViewData["roles"] = _roleManager.Roles.ToList();
            ViewData["rentalAgency"] = _context.RentalAgencies.ToList();
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(IFormFile file, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            var role = _roleManager.FindByIdAsync(Input.Name).Result;
            if (ModelState.IsValid)
            {
                int w = 100;
                int h = 100;

                var stream = new MemoryStream();
                await file.CopyToAsync(stream);
                var image = Image.FromStream(stream);
                Image imageR = ImageResize.ScaleAndCrop(image, w, h);
                var streamToReturn = new MemoryStream();
                imageR.Save(streamToReturn, image.RawFormat);

                //var stream = new MemoryStream();
                //if (file != null)
                //{
                //        await file.CopyToAsync(stream);
                //}

                var user = new ApplicationUser 
                { 
                    UserName = Input.Email, 
                    Email = Input.Email, 
                    FirstName = Input.FistNane,
                    LastName = Input.LastName,
                    Country = Input.Country,
                    City = Input.City,
                    Street = Input.Street,
                    Number = Input.Number,
                    ZIPCode = Input.ZIPCode,
                    Image = streamToReturn.ToArray(),
                    Phone = Input.Phone,
                    RentalAgencyID =Input.RentalAgencyID
                    
                };


                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    await _userManager.AddToRoleAsync(user, role.Name);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            ViewData["roles"] = _roleManager.Roles.ToList(); //dopisane
            return Page();
        }
    }
}
