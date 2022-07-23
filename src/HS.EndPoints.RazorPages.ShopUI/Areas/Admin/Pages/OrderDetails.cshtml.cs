using HS.Domain.Core.Contracts.ApplicationService;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    [Authorize]
    public class OrderDetailsModel : PageModel
    {
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly IOrderFileApplicationService _orderFileApplicationService;
        private readonly ICommentApplicationService _commentApplicationService;
        private readonly IExpertApplicationService _expertApplicationService;
        private readonly IOrderApplicationService _orderApplicationService;
        public ICollection<SuggestionViewModel> suggestions = new List<SuggestionViewModel>();
        public ICollection<OrderFileViewModel> orderFiles = new List<OrderFileViewModel>();
        public string currentUserID { get; set; } = string.Empty;
        public OrderViewModel Order = new OrderViewModel();
        private readonly IMapper _mapper;
        public Guid UserId;
        
        public OrderDetailsModel(ISuggestionApplicationService suggestionApplicationService,
            ICommentApplicationService commentApplicationService,
            IOrderFileApplicationService orderFileApplicationService,
            IExpertApplicationService expertApplicationService,
            IOrderApplicationService orderApplicationService,
            IMapper mapper)
        {
            _suggestionApplicationService = suggestionApplicationService;
            _orderFileApplicationService = orderFileApplicationService;
            _commentApplicationService = commentApplicationService;
            _expertApplicationService = expertApplicationService;
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(int OrderId)
        {
            ClaimsPrincipal currentUser = this.User;
            currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            _mapper.Map(await _orderApplicationService.GetBy(OrderId), Order);
            _mapper.Map(await _suggestionApplicationService.GetAll(OrderId), suggestions);
            _mapper.Map(await _orderFileApplicationService.GetAll(OrderId), orderFiles);
            if (User.IsInRole("Expert"))
            UserId = await _expertApplicationService.GetExpertId(new Guid(currentUserID));
        }

        public async Task<IActionResult> OnPostDeleteImage(int imageId , int orderIdDelete)
        {
            if(ModelState.IsValid)
                await _orderFileApplicationService.DeleteFile(imageId);
                return RedirectToPage("/OrderDetails", new { OrderId = orderIdDelete });

        }

        public async Task<IActionResult> OnPostComment(string Comment,int OrderId,CancellationToken cancellationToken)
        {
            await _commentApplicationService.Create(Comment, OrderId,cancellationToken);
            return RedirectToPage("/OrderDetails", new { OrderId });
        }

        public async Task<IActionResult> OnPostAccept(int SuggId, int OrderId)
        {
            if (ModelState.IsValid)
                await _suggestionApplicationService.Accept(SuggId, OrderId);
            return LocalRedirect("/Admin/Order/");
        }
    }
}
