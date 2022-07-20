using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ISuggestionRepository
    {
        Task<SuggestionDto> GetBy(int id);
        Task<List<SuggestionDto>> GetAll();
        Task<List<SuggestionDto>> GetAll(int orderId);
        Task Create(SuggestionDto entity);
        Task Update(SuggestionDto entity);
        Task<int> GetCount(int orderId);
        Task<bool> EnsureExistSuggestion(int orderId);
    }
}