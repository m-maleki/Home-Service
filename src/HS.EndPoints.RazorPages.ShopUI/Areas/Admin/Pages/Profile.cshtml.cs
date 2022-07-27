using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HS.Domain.Core.Contracts.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HS.Domain.Core.Entities;
using System.Security.Claims;
using HS.Domain.Core.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;
        private readonly ICustomerApplicationService _customerApplicationService;
        private readonly IExpertApplicationService _expertApplicationService;
        private readonly ICityApplicationService _cityApplicationService;
        private readonly IApplicationUserApplicationService _userApplicationService;
        private readonly IExpertRepository _expertRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public ICollection<HomeService> HomeServicesUser { get; set; } = new List<HomeService>();
        public SelectList HomeServices { get; set; } = new SelectList(new List<HomeServiceDto>());
        public SelectList Cities { get; set; } = new SelectList(new List<City>());
        public UserViewModel UserViewModel = new UserViewModel();
        private readonly IMapper _mapper;


        public ProfileModel(IHomeServiceApplicationService homeServiceApplicationService,
            UserManager<ApplicationUser> userManager,
            ICustomerApplicationService customerApplicationService,
            IExpertApplicationService expertApplicationService,
            ICityApplicationService cityApplicationService,
            IExpertRepository expertRepository,
            IMapper mapper,
            IApplicationUserApplicationService userApplicationService)
        {
            _homeServiceApplicationService = homeServiceApplicationService;
            _customerApplicationService = customerApplicationService;
            _expertApplicationService = expertApplicationService;
            _cityApplicationService = cityApplicationService;
            _expertRepository = expertRepository;
            _userManager = userManager;
            _mapper = mapper;
            _userApplicationService = userApplicationService;
        }

        public async Task<IActionResult> OnPost(UserViewModel model)
        {
            if(ModelState.IsValid)
            {
               await _userApplicationService.Update(_mapper.Map(model,new UserDto()));
            }
            return LocalRedirect("/Admin/Profile/");
        }

        public async Task OnGet()
        {
            Cities = new SelectList(await _cityApplicationService.Get(), "Id", "Name");


            if (User.IsInRole("Expert"))
            {
                HomeServices = new SelectList(await _homeServiceApplicationService.Get(), "Id", "Name");
                var expert = await _expertApplicationService.Get();
                if (expert.HomeServices != null)
                HomeServicesUser = expert.HomeServices;
                _mapper.Map(expert, UserViewModel);
            }

            if (User.IsInRole("Customer"))
            {
                var customer = await _customerApplicationService.Get();
                _mapper.Map(customer, UserViewModel);
            }
        }
    }
}
