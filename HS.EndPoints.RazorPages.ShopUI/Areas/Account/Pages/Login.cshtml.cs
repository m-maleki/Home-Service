using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Account.Pages
{

    [Area("Account")]
    public class LoginModel : PageModel
    {
       // private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginModel(SignInManager<ApplicationUser> signInManager,
            ICommentRepository commentRepository)
        {
            //_userManager = userManager;
            _signInManager = signInManager;
        }

        public void OnGet()
        {

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
