using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rental.Data.Data.Areas.Identity.Data;

namespace Rental.WWW.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public ApplicationUser Input { get; set; }


        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            Username = userName;
            Input = user;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Nie można załadować użytkownika ID '{_userManager.GetUserId(User)}'.");
            }
            await LoadAsync(user);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile file)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Nie można załadować użytkownika ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Wystąpił nieoczekiwany błąd z ID '{userId}'.");
                }
            }



            #region Edycja profilu

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

            user.FirstName = Input.FirstName;
            user.LastName = Input.LastName;
            //user.Email = Input.Email;
            //user.Phone = Input.Phone;
            user.Street = Input.Street;
            user.Number = Input.Number;
            user.Country = Input.Country;
            user.City = Input.City;
            user.ZIPCode = Input.ZIPCode;

            var rezult = await _userManager.UpdateAsync(user);

            #endregion Edycja profilu





            if (!rezult.Succeeded)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                throw new InvalidOperationException($"Wystąpił nieoczekiwany błąd podczas ustawiania numeru telefonu dla użytkownika z ID '{userId}'.");
            }



            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Twój profil został zaktualizowany";
            return RedirectToPage();
        }
    }
}
