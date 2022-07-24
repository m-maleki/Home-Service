using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using HS.Domain.Core.Dtos;
namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class HomeServicesModel : PageModel
    {
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly IMapper _mapper;

        public List<HomeServiceViewModel> homeServices;

        public HomeServicesModel(IHomeServiceApplicationService homeServiceApplicationService,
            IOrderApplicationService orderApplicationService,
            IMapper mapper)
        {
            _homeServiceApplicationService = homeServiceApplicationService;
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(int id)
        {
            homeServices = _mapper.Map(await _homeServiceApplicationService.GetAll(id), new List<HomeServiceViewModel>());
        }

        public async Task<IActionResult> OnPostCreate(OrderViewModel model)
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            var OrderDto = _mapper.Map(model, new OrderDto());
            OrderDto.currentApplicationUserID = currentUserID;
            await _orderApplicationService.Create(OrderDto, model.FormFile);
            return LocalRedirect("/");
        }
    }
}
