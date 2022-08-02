using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
     
    public class CommentModel : PageModel
    {
        private readonly ICommentApplicationService _commentApplicationService;
        public List<CommentViewModel> comments;

        private readonly IMapper _mapper;

        public CommentModel(ICommentApplicationService commentApplicationService,
            IMapper mapper)
        {
            _commentApplicationService = commentApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(CancellationToken cancellationToken)
        {

            var records = await _commentApplicationService.GetAll(cancellationToken);
            comments = _mapper.Map(records, comments);
        }

        public async Task<IActionResult> OnPostActive(int commentId,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
                await _commentApplicationService.Active(commentId, cancellationToken);
                return LocalRedirect("/Admin/comment");
        }

        public async Task<IActionResult> OnPostDeActive(int commentId,CancellationToken cancellationToken)
        {
            if(ModelState.IsValid)
            await _commentApplicationService.DeActive(commentId,cancellationToken);
            return LocalRedirect("/Admin/comment");
        }
    }
}
