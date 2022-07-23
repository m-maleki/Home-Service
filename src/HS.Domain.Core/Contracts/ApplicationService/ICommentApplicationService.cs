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
        Task<CommentDto> GetBy(int id);
        Task<List<CommentDto>> GetAll();
        Task Create(string comment , int orderId,CancellationToken cancellationToken);
        Task Update(CommentDto entity);
        Task<List<CommentDto>> GetBy(Guid expertId);
        Task Active(int commentId);
        Task DeActive(int commentId);
    }
}
