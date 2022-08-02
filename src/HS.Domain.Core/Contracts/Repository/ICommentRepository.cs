using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System.Linq.Expressions;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ICommentRepository
    {
        Task<CommentDto> GetBy(int id, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetBy(Guid expertId, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAll(CancellationToken cancellationToken);
        Task Create(string comment, Guid expertId ,CancellationToken cancellationToken);
        Task Update(CommentDto entity, CancellationToken cancellationToken);
        Task Active(int commentId, CancellationToken cancellationToken);
        Task DeActive(int commentId, CancellationToken cancellationToken);
    }
}
