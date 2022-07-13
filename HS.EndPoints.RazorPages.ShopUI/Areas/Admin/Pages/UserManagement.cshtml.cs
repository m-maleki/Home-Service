using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Admin.Pages
{
    public class UserManagementModel : PageModel
    {
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public List<UserViewModel> users;
        public List<SelectListItem> roles;
        public UserManagementModel(UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task OnGet()
        {
             roles = await _roleManager.Roles.Select(x=> new SelectListItem
             {
                 Text = x.Name,
                 Value = x.Name,
             } ).ToListAsync();
             users = await _userManager.Users.Select(x=> new UserViewModel()
            {
                Id = x.Id,
                UserName = x.UserName,
                Email = x.Email,
                Role = string.Join(",", _userManager.GetRolesAsync(x).Result.ToArray())
            }).ToListAsync();
        }

        public async Task OnPostDelete(int id)
        {
            var user = await _userManager.Users.Where(x => x.Id == id).SingleAsync();
           await _userManager.DeleteAsync(user);
            OnGet();
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
                  // var test =await _userManager.AddToRoleAsync(user, model.Role);
                    OnGet();
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
