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
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public RegisterModel(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole<Guid>> roleManager)
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

        public async Task<IActionResult> OnPostCreate(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Expert expert = new Expert {
                //};

                Customer customer = new Customer
                {
                };

                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                  //  Expert = expert,
                    Customer = customer
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect("~/Admin/");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                        return default;
                    }
                }
            }
            return default;
        }
    }
}
