using HS.Domain.Core.Entities;
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
        //private readonly SignInManager<IdentityUser<Guid>> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public List<UserViewModel> users;
        public List<SelectListItem> roles;
        public UserManagementModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            _userManager = userManager;
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

        public async Task OnPostDelete(Guid id)
        {
            var user = await _userManager.Users.Where(x => x.Id == id).SingleAsync();
           await _userManager.DeleteAsync(user);
            OnGet();
        }

        public async Task OnPostCreate(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
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
