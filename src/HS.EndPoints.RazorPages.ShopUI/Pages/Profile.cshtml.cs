using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Dtos.ApplicationUsers;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ICustomerApplicationService _customerApplicationService;
        private readonly IExpertApplicationService _expertApplicationService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IApplicationUserApplicationService _applicationUserApplicationService;
        private readonly IApplicationUserApplicationService _userApplicationService;

        private readonly IMapper _mapper;
        public UserViewModel CurrentUser = new UserViewModel();
        public ICollection<OrderViewModel>? Orders = new List<OrderViewModel>();

        public ProfileModel(ICustomerApplicationService customerApplicationService,
            IExpertApplicationService expertApplicationService,
            ISuggestionApplicationService suggestionApplicationService,
            SignInManager<ApplicationUser> signInManager,
            IApplicationUserApplicationService applicationUserApplicationService,
            UserManager<ApplicationUser> userManager,
            IOrderApplicationService orderApplicationService,
            IMapper mapper,
            IApplicationUserApplicationService userApplicationService)
        {
            _suggestionApplicationService = suggestionApplicationService;
            _customerApplicationService = customerApplicationService;
            _expertApplicationService = expertApplicationService;
            _signInManager = signInManager;
            _applicationUserApplicationService = applicationUserApplicationService;
            _mapper = mapper;
            _userManager = userManager;
            _orderApplicationService = orderApplicationService;
            _userApplicationService = userApplicationService;
        }

        public async Task OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                CurrentUser = _mapper.Map(await _userApplicationService.Get(), CurrentUser);
                Orders = _mapper.Map(await _orderApplicationService.GetAll(), Orders);
            }
        }
        public async Task<IActionResult> OnPost(UserViewModel model)
        {
            await _userApplicationService.Update(_mapper.Map(model, new UserDto()));
            return LocalRedirect("/Profile");
        }
        public async Task<IActionResult> OnPostLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _applicationUserApplicationService.Login(_mapper.Map(model, new ApplicationUserDto()));
                if(result.Succeeded)
                return LocalRedirect("/Profile");
                else
                ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است *");
            }
            return default;
        }

        public async Task<IActionResult> OnPostLogout()
        {
            await _signInManager.SignOutAsync();
            return LocalRedirect("/Profile");
        }

        public async Task<IActionResult> OnPostAccept(int SuggId, int OrderId)
        {
            if (ModelState.IsValid)
                await _suggestionApplicationService.Accept(SuggId, OrderId);
            return LocalRedirect("/Profile");
        }

        public async Task<IActionResult> OnPostCreateSuggest(SuggestionViewModel model)
        {

            await _suggestionApplicationService.Create(_mapper.Map(model, new SuggestionDto()));
            return LocalRedirect("/Profile");
        }

        public async Task<IActionResult> OnPostCreate(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _applicationUserApplicationService.Create(_mapper.Map(model, new ApplicationUserDto()));
                if (result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);
                    return LocalRedirect("~/Profile");
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
