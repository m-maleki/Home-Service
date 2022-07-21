using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class OrderDetailsModel : PageModel
    {
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly IOrderFileApplicationService _orderFileApplicationService;
        private readonly IExpertApplicationService _expertApplicationService;
        private readonly ICommentApplicationService _commentApplicationService;

        public List<SuggestionViewModel> suggestions = new();
        public List<OrderFileViewModel> orderFiles = new();
        public OrderViewModel Order;
        private readonly IMapper _mapper;
        public string currentUserID { get; set; }
        public Guid UserId;
        public OrderDetailsModel(IOrderApplicationService orderApplicationService,
            IMapper mapper,
            ISuggestionApplicationService suggestionApplicationService,
            IOrderFileApplicationService orderFileApplicationService,
            IExpertApplicationService expertApplicationService,
            ICommentApplicationService commentApplicationService)
        {
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
            _suggestionApplicationService = suggestionApplicationService;
            _orderFileApplicationService = orderFileApplicationService;
            _expertApplicationService = expertApplicationService;
            _commentApplicationService = commentApplicationService;
        }

        public async Task OnGet(int OrderId)
        {
            ClaimsPrincipal currentUser = this.User;
            currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            if(User.IsInRole("Expert"))
            UserId = await _expertApplicationService.GetExpertId(new Guid(currentUserID));

            var orderRecord = await _orderApplicationService.GetBy(OrderId);
            Order= _mapper.Map(orderRecord, Order);

            var suggestionRecords = await _suggestionApplicationService.GetAll(OrderId);
            _mapper.Map(suggestionRecords, suggestions);

            var orderFileRecords = await _orderFileApplicationService.GetAll(OrderId);
            _mapper.Map(orderFileRecords, orderFiles);
        }

        public async Task<IActionResult> OnPostDeleteImage(int imageId)
        {
             await _orderFileApplicationService.DeleteFile(imageId);
            return LocalRedirect("/Admin/Order/");
        }

        public async Task<IActionResult> OnPostComment(string Comment,int OrderId)
        {
            await _commentApplicationService.Create(Comment, OrderId);
            RedirectToAction("Action", "Controller");
            return RedirectToPage("/OrderDetails", new { OrderId });

        }
    }
}
