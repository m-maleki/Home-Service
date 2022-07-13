using HS.Domain.Core.Entities;
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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public RegisterModel(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
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
                Expert expert = new Expert {
                    Address = model.Password
                };
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Expert = expert

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
