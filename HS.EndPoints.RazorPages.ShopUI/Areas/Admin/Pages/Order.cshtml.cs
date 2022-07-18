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

        public List<OrderViewModel>? Orders;
        private readonly IMapper _mapper;
        public SelectList HomeServices { get; set; }

        public OrderModel(IOrderApplicationService orderApplicationService,
            IMapper mapper,
            IHomeServiceApplicationService homeServiceApplicationService)
        {
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
            _homeServiceApplicationService = homeServiceApplicationService;
        }

        public async Task OnGet()
        {
            HomeServices = new SelectList(await _homeServiceApplicationService.Get(), "Id", "Name");


            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            var result = await _orderApplicationService.GetAllBy(new Guid(currentUserID));
            Orders = _mapper.Map(result, Orders);
        }

        public async Task<IActionResult> OnPostCreate(OrderViewModel model)
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            var OrderDto = new OrderDto();
            _mapper.Map(model, OrderDto);
            OrderDto.currentApplicationUserID = currentUserID;
           await _orderApplicationService.Create(OrderDto);

            return LocalRedirect("/Admin/Order");
            
        }
    }
}
