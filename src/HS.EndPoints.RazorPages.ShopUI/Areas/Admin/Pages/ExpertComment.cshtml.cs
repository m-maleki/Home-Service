using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    [Authorize(Roles = "Admin,Customer")]
    public class ExpertCommentModel : PageModel
    {

        private readonly ICommentApplicationService _commentApplicationService;
        public List<CommentViewModel> comments;
        private readonly IMapper _mapper;

        public ExpertCommentModel(ICommentApplicationService commentApplicationService,
            IMapper mapper)
        {
            _commentApplicationService = commentApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(Guid ExpertId,CancellationToken cancellationToken)
        {
            var result = await _commentApplicationService.GetBy(ExpertId, cancellationToken);
            comments =  _mapper.Map(result, comments);
            
        }
    }
}
