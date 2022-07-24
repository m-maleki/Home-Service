using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    [Authorize]
    public class OrderModel : PageModel
    {
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IExpertApplicationService _expertApplicationService;

        public ICollection<OrderViewModel>? Orders = new List<OrderViewModel>();
        public string currentUserID { get; set; } = String.Empty;
        public SelectList HomeServices { get; set; }
        private readonly IMapper _mapper;
        public Guid UserId;

        public OrderModel(IOrderApplicationService orderApplicationService,
            IMapper mapper,
            IHomeServiceApplicationService homeServiceApplicationService,
            ISuggestionApplicationService suggestionApplicationService,
            UserManager<ApplicationUser> userManager,
            IExpertApplicationService expertApplicationService)
        {
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
            _homeServiceApplicationService = homeServiceApplicationService;
            _suggestionApplicationService = suggestionApplicationService;
            _userManager = userManager;
            _expertApplicationService = expertApplicationService;
        }

        public async Task OnGet()
        {
            ClaimsPrincipal currentUser = this.User;
            currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            HomeServices = new SelectList(await _homeServiceApplicationService.Get(), "Id", "Name");

            var roles = await _userManager.GetRolesAsync(await _userManager.FindByEmailAsync(User.Identity!.Name));

            Orders = _mapper.Map(await _orderApplicationService.GetAllBy(new Guid(currentUserID), roles), Orders);
            if (User.IsInRole("Expert"))
                UserId = await _expertApplicationService.GetExpertId(new Guid(currentUserID));
        }

        public async Task<IActionResult> OnPostCreate(OrderViewModel model)
        {
                ClaimsPrincipal currentUser = this.User;
                currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
                var OrderDto = _mapper.Map(model, new OrderDto());
                OrderDto.currentApplicationUserID = currentUserID;
                await _orderApplicationService.Create(OrderDto, model.FormFile);
                return LocalRedirect("/Admin/Order");
        }

        public async Task<IActionResult> OnPostCreateSuggest(SuggestionViewModel model)
        {

                await _suggestionApplicationService.Create(_mapper.Map(model, new SuggestionDto()));
            return LocalRedirect("/Admin/Order");
        }

        public async Task<IActionResult> OnPostDeleteOrder(int OrderIdDelete)
        {
            if (ModelState.IsValid)
                await _orderApplicationService.SoftDelete(OrderIdDelete);
            return LocalRedirect("/Admin/Order");
        }

        public async Task<IActionResult> OnPostRecover(int OrderId)
        {
            if (ModelState.IsValid)
                await _orderApplicationService.SoftRecover(OrderId);
            return LocalRedirect("/Admin/Order");
        }


    }
}
