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
        Task<SuggestionDto> Get(int Id);
        Task<List<SuggestionDto>> Get();
        Task<List<SuggestionDto>> GetAll(int orderId);
        Task Create(SuggestionDto entity);
        Task Update(SuggestionDto entity);
        Task EnsureExists(int Id);
        Task EnsureDoesNotExist(int Id);
        Task<int> GetCount(int orderId);
        Task<bool> EnsureExistSuggestion(int orderId);
    }
}
