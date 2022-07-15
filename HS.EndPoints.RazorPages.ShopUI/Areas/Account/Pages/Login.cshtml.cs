using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Account.Pages
{

    [Area("Account")]
    public class LoginModel : PageModel
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly SeedIdentityData _seedIdentityData;

        public LoginModel(SignInManager<ApplicationUser> signInManager,
            SeedIdentityData seedIdentityData)
        {

            _signInManager = signInManager;
            _seedIdentityData = seedIdentityData;
        }

        public async Task OnGet()
        {
                await _seedIdentityData.Inistialize();
        }

        public async Task OnPostLogout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IActionResult> OnPostLogin(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RemomberMe, false);
                if (result.Succeeded)
                {
                      return LocalRedirect("~/Admin/");
                }
                ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است *");
            }
            return default;
        }
    }
}
