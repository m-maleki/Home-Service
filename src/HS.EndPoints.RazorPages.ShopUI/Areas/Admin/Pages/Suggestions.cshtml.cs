using HS.Domain.Core.Contracts.ApplicationService;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    [Authorize(Roles = "Admin,Customer")]
    public class SuggestionsModel : PageModel
    {
        public ICollection<SuggestionViewModel> suggestions = new List<SuggestionViewModel>();
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly IMapper _mapper;

        public SuggestionsModel(ISuggestionApplicationService suggestionApplicationService,
            IMapper mapper)
        {
            _suggestionApplicationService = suggestionApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(int orderId,CancellationToken cancellationToken)
        {
            if(ModelState.IsValid)
            _mapper.Map(await _suggestionApplicationService.GetAll(orderId, cancellationToken),suggestions);
        }

        public async Task<IActionResult> OnPostAccept(int SuggId , int OrderId, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
                await _suggestionApplicationService.Accept(SuggId, OrderId, cancellationToken);
            return LocalRedirect("/Admin/Order/");
        }

    }
}
