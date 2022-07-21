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
        Task<CommentDto> Get(int Id);
        Task<List<CommentDto>> Get();
        Task Create(string comment,Guid expertId);
        Task EnsureExists(int Id);
        Task EnsureDoesNotExist(int Id);
        Task Update(CommentDto entity);
    }
}
