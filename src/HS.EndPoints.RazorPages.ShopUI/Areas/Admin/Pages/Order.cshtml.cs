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

        public async Task OnGet(CancellationToken cancellationToken)
        {

            HomeServices = new SelectList(await _homeServiceApplicationService.Get(cancellationToken), "Id", "Name");
            Orders = _mapper.Map(await _orderApplicationService.GetAll(cancellationToken), Orders);
            if (User.IsInRole("Expert"))
                UserId = await _expertApplicationService.GetExpertId(cancellationToken);
        }

        public async Task<IActionResult> OnPostCreate(OrderViewModel model,CancellationToken cancellationToken)
        {
                await _orderApplicationService.Create(_mapper.Map(model, new OrderDto()), model.FormFile, cancellationToken);
                return LocalRedirect("/Admin/Order");
        }

        public async Task<IActionResult> OnPostCreateSuggest(SuggestionViewModel model,CancellationToken cancellationToken)
        {

                await _suggestionApplicationService.Create(_mapper.Map(model, new SuggestionDto()), cancellationToken);
            return LocalRedirect("/Admin/Order");
        }

        public async Task<IActionResult> OnPostDeleteOrder(int OrderIdDelete,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
                await _orderApplicationService.SoftDelete(OrderIdDelete, cancellationToken);
            return LocalRedirect("/Admin/Order");
        }

        public async Task<IActionResult> OnPostRecover(int OrderId,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
                await _orderApplicationService.SoftRecover(OrderId, cancellationToken);
            return LocalRedirect("/Admin/Order");
        }


    }
}
