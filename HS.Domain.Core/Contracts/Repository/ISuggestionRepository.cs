using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ISuggestionRepository
    {
        Task<SuggestionDto> GetBy(int id);
        Task<List<SuggestionDto>> GetAll();
        Task Create(SuggestionDto entity);
        Task Update(SuggestionDto entity);
    }
}