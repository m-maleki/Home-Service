using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class CommentApplicationService : ICommentApplicationService
    {
        private readonly ICommentService _commentService;
        private readonly ISuggestionService _suggestionService;

        public CommentApplicationService(ICommentService commentService,
            ISuggestionService suggestionService)
        {
            _commentService = commentService;
            _suggestionService = suggestionService;
        }

        public async Task Active(int commentId, CancellationToken cancellationToken)
        {
            await _commentService.Active(commentId, cancellationToken);
        }

        public async Task Create(string comment,int orderId,CancellationToken cancellationToken)
        {
            var expertId =await _suggestionService.GetAcceptSuggestionExpertId(orderId, cancellationToken);
            await _commentService.Create(comment,expertId,cancellationToken);
        }

        public async Task DeActive(int commentId, CancellationToken cancellationToken)
        {
            await _commentService.DeActive(commentId, cancellationToken);
        }

        public async Task<List<CommentDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _commentService.GetAll(cancellationToken);
        }

        public Task<CommentDto> GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CommentDto>> GetBy(Guid expertId, CancellationToken cancellationToken)
        {
            return await _commentService.GetBy(expertId, cancellationToken);
        }

        public Task Update(CommentDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
