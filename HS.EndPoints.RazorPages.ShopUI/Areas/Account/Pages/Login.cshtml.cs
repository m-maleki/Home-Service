using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Account.Pages
{

    [Area("Account")]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;

        public LoginModel(UserManager<IdentityUser<int>> userManager,
            SignInManager<IdentityUser<int>> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public void OnGet()
        {
           // await _signInManager.SignOutAsync();
        }

        public async Task OnPostLogout()
        {
            await _signInManager.SignOutAsync();
            // redirecto to homepage
        }

        public async Task OnPostLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RemomberMe, false);
                if (result.Succeeded)
                {
                    LocalRedirect("~/");
                }
                ModelState.AddModelError(string.Empty, "خطا در ورود به سایت");
            }
        }
    }
}
