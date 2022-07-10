using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Account.Pages
{
    [Area("Account")]
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public RegisterModel(UserManager<IdentityUser<int>> userManager,
            SignInManager<IdentityUser<int>> signInManager,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task OnGet()
        {
            //var adminRoleResult = await _roleManager.CreateAsync(new IdentityRole<int>("AdminRole"));
            //var adminUser = await _userManager.CreateAsync(new IdentityUser<int>("Admin"), "25915491");
            //var assignRole = await _userManager.AddToRoleAsync(new IdentityUser<int>("Admin"), "AdminRole");
        }

        public async Task OnPostCreate(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser<int>
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    LocalRedirect("~/");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                    }
                }
            }
        }
    }
}
