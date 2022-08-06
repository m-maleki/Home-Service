using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Dtos.ApplicationUsers;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        public LoginViewModel loginModel;
        public RegisterViewModel registerModel;
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
            IApplicationUserApplicationService userApplicationService,
            Microsoft.AspNetCore.Identity.IPasswordHasher<ApplicationUser> passwordHasher)
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
            _passwordHasher = passwordHasher;
        }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            if (User.Identity.IsAuthenticated)
            {
                CurrentUser = _mapper.Map(await _userApplicationService.Get(cancellationToken), CurrentUser);
                Orders = _mapper.Map(await _orderApplicationService.GetAll(cancellationToken), Orders);
            }
        }
        public async Task<IActionResult> OnPostUpdate(UserViewModel model,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            await _userApplicationService.Update(_mapper.Map(model, new UserDto()), cancellationToken);
            return LocalRedirect("/Profile");
        }
        public async Task<IActionResult> OnPostLogin(LoginViewModel loginModel,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.Users.FirstOrDefault(x => x.Email == loginModel.Email);
                
 
                var result = await _applicationUserApplicationService.Login(_mapper.Map(loginModel, new ApplicationUserDto()), cancellationToken);
                if(result.Succeeded)
                {
                    return LocalRedirect("/Profile");
                }
                else if (user != null)
                {
                    if (_passwordHasher.VerifyHashedPassword(user, user.PasswordHash, loginModel.Password) != PasswordVerificationResult.Failed
                        && !await _applicationUserApplicationService.EmailIsConfirmed(loginModel.Email))
                    {
                        ModelState.AddModelError(string.Empty, "ایمیل کاربری تایید نشده است");
                        return default;
                    }
                }
                if(!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است");
                }
            }
            return default;
        }

        public async Task<IActionResult> OnPostLogout()
        {
            await _signInManager.SignOutAsync();
            return LocalRedirect("/Profile");
        }

        public async Task<IActionResult> OnPostAccept(int SuggId, int OrderId,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
                await _suggestionApplicationService.Accept(SuggId, OrderId, cancellationToken);
            return LocalRedirect("/Profile");
        }

        public async Task<IActionResult> OnPostCreateSuggest(SuggestionViewModel model,CancellationToken cancellationToken)
        {

            await _suggestionApplicationService.Create(_mapper.Map(model, new SuggestionDto()), cancellationToken);
            return LocalRedirect("/Profile");
        }

        public async Task<IActionResult> OnPostCreate(RegisterViewModel registerModel,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var result = await _applicationUserApplicationService.Create(_mapper.Map(registerModel, new ApplicationUserDto()), cancellationToken);
                if (result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "ثبت نام با موفقیت انجام شد");
                    ModelState.AddModelError(string.Empty, "ایمیل فعالسازی ارسال گردید");
                    //await _signInManager.PasswordSignInAsync(registerModel.Email, registerModel.Password, true, false);
                    // return LocalRedirect("/Profile");
                    return default;
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
