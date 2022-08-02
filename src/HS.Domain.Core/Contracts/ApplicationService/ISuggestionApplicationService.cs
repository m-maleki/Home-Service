using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface ISuggestionApplicationService
    {
        Task<SuggestionDto> Get(int Id, CancellationToken cancellationToken);
        Task<List<SuggestionDto>> Get(CancellationToken cancellationToken);
        Task<List<SuggestionDto>> GetAll(int orderId, CancellationToken cancellationToken);
        Task Create(SuggestionDto entity, CancellationToken cancellationToken);
        Task Update(SuggestionDto entity, CancellationToken cancellationToken);
        Task EnsureExists(int Id, CancellationToken cancellationToken);
        Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken);
        Task<int> GetCount(int orderId, CancellationToken cancellationToken);
        Task<bool> EnsureExistSuggestion(int orderId, CancellationToken cancellationToken);
        Task Accept(int suggestionId , int orderId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);
    }
}
