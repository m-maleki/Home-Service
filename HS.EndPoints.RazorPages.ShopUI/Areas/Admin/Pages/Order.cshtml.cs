using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderApplicationService _orderApplicationService;
        public List<OrderViewModel>? Orders;
        private readonly IMapper _mapper;

        public OrderModel(IOrderApplicationService orderApplicationService, IMapper mapper)
        {
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            var result = await _orderApplicationService.GetAllBy(new Guid(currentUserID));
            Orders = _mapper.Map(result, Orders);
        }
    }
}
