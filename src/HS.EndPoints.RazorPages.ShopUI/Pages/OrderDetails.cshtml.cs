using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class OrderDetailsModel : PageModel
    {
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly IOrderFileApplicationService _orderFileApplicationService;
        private readonly ICommentApplicationService _commentApplicationService;
        private readonly IExpertApplicationService _expertApplicationService;
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly IMapper _mapper;
        public ICollection<SuggestionViewModel> suggestions = new List<SuggestionViewModel>();
        public ICollection<OrderFileViewModel> orderFiles = new List<OrderFileViewModel>();
        public string currentUserID { get; set; } = string.Empty;
        public OrderViewModel Order = new OrderViewModel();

        public Guid UserId;

        public OrderDetailsModel(ISuggestionApplicationService suggestionApplicationService,
            IOrderFileApplicationService orderFileApplicationService,
            ICommentApplicationService commentApplicationService,
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

        public async Task OnGet(int OrderId,CancellationToken cancellationToken)
        {
            
            _mapper.Map(await _orderApplicationService.GetBy(OrderId, cancellationToken), Order);
            _mapper.Map(await _suggestionApplicationService.GetAll(OrderId, cancellationToken), suggestions);
            _mapper.Map(await _orderFileApplicationService.GetAll(OrderId, cancellationToken), orderFiles);
            if (User.IsInRole("Expert"))
                UserId = await _expertApplicationService.GetExpertId(cancellationToken);
        }
        public async Task<IActionResult> OnPostDeleteImage(int imageId, int orderIdDelete,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
                await _orderFileApplicationService.DeleteFile(imageId, cancellationToken);
            return RedirectToPage("/OrderDetails", new { OrderId = orderIdDelete });

        }

        public async Task<IActionResult> OnPostComment(string Comment, int OrderId, CancellationToken cancellationToken)
        {
            await _commentApplicationService.Create(Comment, OrderId, cancellationToken);
            return RedirectToPage("/OrderDetails", new { OrderId });
        }

        public async Task<IActionResult> OnPostAccept(int SuggId, int OrderId,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
                await _suggestionApplicationService.Accept(SuggId, OrderId, cancellationToken);
            return LocalRedirect("/Admin/Order/");
        }
    }
}
