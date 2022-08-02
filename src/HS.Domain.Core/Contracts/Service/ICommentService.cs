using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface ICommentService
    {
        Task<CommentDto> Get(int Id, CancellationToken cancellationToken);
        Task<List<CommentDto>> Get(CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAll(CancellationToken cancellationToken);
        Task Create(string comment,Guid expertId,CancellationToken cancellationToken);
        Task<List<CommentDto>> GetBy(Guid expertId, CancellationToken cancellationToken);
        Task EnsureExists(int Id, CancellationToken cancellationToken);
        Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken);
        Task Update(CommentDto entity, CancellationToken cancellationToken);
        Task Active(int commentId, CancellationToken cancellationToken);
        Task DeActive(int commentId, CancellationToken cancellationToken);
    }
}
