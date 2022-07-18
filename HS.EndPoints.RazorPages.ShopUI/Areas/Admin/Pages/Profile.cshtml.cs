using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly IExpertApplicationService _expertApplicationService;
        private readonly ICityApplicationService _cityApplicationService;
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;
        private readonly ICustomerApplicationService _customerApplicationService;
        public SelectList Cities { get; set; }
        public SelectList HomeServices { get; set; }
        public List<HomeService> HomeServicesUser { get; set; } = new List<HomeService>();
        private readonly IMapper _mapper;

        public ProfileModel(IExpertApplicationService expertApplicationService,
            IMapper mapper,
            ICityApplicationService cityApplicationService,
            IHomeServiceApplicationService homeServiceApplicationService,
            ICustomerApplicationService customerApplicationService)
        {
            _expertApplicationService = expertApplicationService;
            _mapper = mapper;
            _cityApplicationService = cityApplicationService;
            _homeServiceApplicationService = homeServiceApplicationService;
            _customerApplicationService = customerApplicationService;
        }

        public UserViewModel UserViewModel = new UserViewModel();

        public async Task<IActionResult> OnPost(UserViewModel model)
        {
            var user = new ExpertDto();
            _mapper.Map(model, user);
            await _expertApplicationService.Update(user);
            return LocalRedirect("/Admin/Profile/");
        }

        public async Task OnGet()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            Cities = new SelectList(await _cityApplicationService.Get(), "Id", "Name");

            if (User.IsInRole("Expert"))
            {
                var expert = await _expertApplicationService.Get(new Guid(currentUserID));
                if (expert.HomeServices != null)
                    HomeServicesUser = expert.HomeServices;
                HomeServices = new SelectList(await _homeServiceApplicationService.Get(), "Id", "Name");
                var user = await _expertApplicationService.Get(User.Identity.Name);
                _mapper.Map(user, UserViewModel);
            }

            if (User.IsInRole("Customer"))
            {
                var customer = await _customerApplicationService.Get(new Guid(currentUserID));
                var user = await _customerApplicationService.Get(User.Identity.Name);
                _mapper.Map(user, UserViewModel);
            }
        }
    }
}