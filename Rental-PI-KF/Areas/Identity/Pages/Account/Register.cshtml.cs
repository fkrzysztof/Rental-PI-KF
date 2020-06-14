using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
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
            [Required(ErrorMessage = "Pole wymagane")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Pole wymagane")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string Name { get; set; }

            [Display(Name = "Imię")]
            public string FistNane { get; set; }

            [Display(Name = "Nazwisko")]
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
            public string PhoneNumber { get; set; }

            [Display(Name = "Oddział")]
            public int? RentalAgencyID { get; set; }
        }

        public async Task OnGet(string returnUrl = null)
        {
            ViewData["roles"] = _roleManager.Roles.Where(w => w.Name != "Zablokowani" && w.Name != "Klient").ToList();
            ViewData["rentalAgency"] = _context.RentalAgencies.Where(w => w.IsActive == true).ToList();
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(IFormFile file, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            var role = _roleManager.FindByIdAsync(Input.Name).Result;
            if (ModelState.IsValid)
            {

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
                    Image = null,
                    PhoneNumber = Input.PhoneNumber,
                    RentalAgencyID = Input.RentalAgencyID
                };

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

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    await _userManager.AddToRoleAsync(user, role.Name);

                    #region Email


                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Potwierdź konto",
                        $"Potwierdź swoje konto przez <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>kliknij tutaj</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }

                    #endregion

                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    //return LocalRedirect(returnUrl);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            ViewData["roles"] = _roleManager.Roles.Where(w => w.Name != "Zablokowani" && w.Name != "Klient").ToList();
            ViewData["rentalAgency"] = _context.RentalAgencies.Where(w => w.IsActive == true).ToList();
            return Page();
        }
    }
}