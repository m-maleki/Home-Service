using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;
        private readonly ISuggestionApplicationService _suggestionApplicationService;


        public List<OrderViewModel>? Orders;
        private readonly IMapper _mapper;
        public string currentUserID { get; set; }
        public SelectList HomeServices { get; set; }

        public OrderModel(IOrderApplicationService orderApplicationService,
            IMapper mapper,
            IHomeServiceApplicationService homeServiceApplicationService,
            ISuggestionApplicationService suggestionApplicationService)
        {
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
            _homeServiceApplicationService = homeServiceApplicationService;
            _suggestionApplicationService = suggestionApplicationService;
        }

        public async Task OnGet()
        {
            HomeServices = new SelectList(await _homeServiceApplicationService.Get(), "Id", "Name");
            ClaimsPrincipal currentUser = this.User;
            currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            bool isExpert = User.IsInRole("Expert");
            var result = await _orderApplicationService.GetAllBy(new Guid(currentUserID), isExpert);
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
    }
}
