using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface ISuggestionService
    {
        Task<Suggestion> Get(int Id);
        Task<List<Suggestion>> Get();
        Task Create(Suggestion entity);
        Task Update(Suggestion entity);
        Task EnsureExists(int Id);
        Task EnsureDoesNotExist(int Id);

    }
}
