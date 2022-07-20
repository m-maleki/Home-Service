using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IExpertApplicationService _expertApplicationService;


        public List<OrderViewModel>? Orders;
        private readonly IMapper _mapper;
        public string currentUserID { get; set; }
        public SelectList HomeServices { get; set; }
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
            var user = await _userManager.FindByEmailAsync(User.Identity!.Name);
            var roles = await  _userManager.GetRolesAsync(user);
            ClaimsPrincipal currentUser = this.User;
            currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            HomeServices = new SelectList(await _homeServiceApplicationService.Get(), "Id", "Name");
            var result = await _orderApplicationService.GetAllBy(new Guid(currentUserID), roles);
            if(User.IsInRole("Expert"))
            UserId = await _expertApplicationService.GetExpertId(new Guid(currentUserID));
            Orders = _mapper.Map(result, Orders);
        }

        public async Task<IActionResult> OnPostCreate(OrderViewModel model)
        {
            ClaimsPrincipal currentUser = this.User;
            currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            var OrderDto = new OrderDto();
            _mapper.Map(model, OrderDto);
            OrderDto.currentApplicationUserID = currentUserID;
           await _orderApplicationService.Create(OrderDto,model.FormFile);
            return LocalRedirect("/Admin/Order");
            
        }

        public async Task<IActionResult> OnPostCreateSuggest(SuggestionViewModel model)
        {
            var suggestionDto = new SuggestionDto();
            _mapper.Map(model, suggestionDto);
            await _suggestionApplicationService.Create(suggestionDto);
            return LocalRedirect("/Admin/Order");
        }

        public async Task<IActionResult> OnPostDeleteOrder(int OrderIdDelete)
        {
            await _orderApplicationService.SoftDelete(OrderIdDelete);
            return LocalRedirect("/Admin/Order");
        }

        public async Task<IActionResult> OnPostRecover(int OrderId)
        {
            await _orderApplicationService.SoftRecover(OrderId);
            return LocalRedirect("/Admin/Order");
        }

        
    }
}
