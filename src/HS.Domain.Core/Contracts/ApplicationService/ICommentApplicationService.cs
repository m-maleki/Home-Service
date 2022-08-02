using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface ICommentApplicationService
    {
        Task<CommentDto> GetBy(int id, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAll(CancellationToken cancellationToken);
        Task Create(string comment , int orderId,CancellationToken cancellationToken);
        Task Update(CommentDto entity, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetBy(Guid expertId, CancellationToken cancellationToken);
        Task Active(int commentId, CancellationToken cancellationToken);
        Task DeActive(int commentId, CancellationToken cancellationToken);
    }
}
