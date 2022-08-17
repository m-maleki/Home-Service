using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Active(int commentId, CancellationToken cancellationToken)
        {
           await _commentRepository.Active(commentId, cancellationToken);
        }

        public async Task Create(string comment, Guid expertId,CancellationToken cancellationToken)
        {
            await _commentRepository.Create(comment, expertId, cancellationToken);
        }

        public async Task DeActive(int commentId, CancellationToken cancellationToken)
        {
            await _commentRepository.DeActive(commentId, cancellationToken);
        }

        public async Task<List<CommentDto>> GetAll(CancellationToken cancellationToken)
           => await _commentRepository.GetAll(cancellationToken);

        public async Task<List<CommentDto>> GetBy(Guid expertId, CancellationToken cancellationToken)
           => await _commentRepository.GetBy(expertId, cancellationToken);

        public Task Update(CommentDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> Get(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentDto>> Get(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
