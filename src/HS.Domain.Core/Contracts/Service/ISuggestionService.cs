using HS.Domain.Core.Dtos;
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
        Task<SuggestionDto> Get(int Id,CancellationToken cancellationToken);
        Task<List<SuggestionDto>> Get(CancellationToken cancellationToken);
        Task<List<SuggestionDto>> GetAll(int orderId, CancellationToken cancellationToken);
        Task Create(SuggestionDto entity, CancellationToken cancellationToken);
        Task Update(SuggestionDto entity, CancellationToken cancellationToken);
        Task EnsureExists(int Id, CancellationToken cancellationToken);
        Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken);
        Task<int> GetCount(int orderId, CancellationToken cancellationToken);
        Task<bool> EnsureExistSuggestion(int orderId, CancellationToken cancellationToken);
        Task Accept(int suggestionId, CancellationToken cancellationToken);
        Task<Guid> GetAcceptSuggestionExpertId(int orderId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);

    }
}
