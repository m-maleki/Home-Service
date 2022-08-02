using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ISuggestionRepository
    {
        Task<SuggestionDto> GetBy(int id, CancellationToken cancellationToken);
        Task<List<SuggestionDto>> GetAll(CancellationToken cancellationToken);
        Task<List<SuggestionDto>> GetAll(int orderId, CancellationToken cancellationToken);
        Task Create(SuggestionDto entity, CancellationToken cancellationToken);
        Task Update(SuggestionDto entity, CancellationToken cancellationToken);
        Task<int> GetCount(int orderId, CancellationToken cancellationToken);
        Task<bool> EnsureExistSuggestion(int orderId, CancellationToken cancellationToken);
        Task Accept(int suggestionId, CancellationToken cancellationToken);
        Task<Guid> GetAcceptSuggestionExpertId(int orderId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);
    }
}