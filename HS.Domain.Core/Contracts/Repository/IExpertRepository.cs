using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IExpertRepository 
    {
        Task<ExpertDto> GetBy(Guid id);
        Task<ExpertDto> GetBy(string mobileNumber);
        Task<List<ExpertDto>> GetAll();
        Task Create(ExpertDto entity);
        Task Update(ExpertDto entity);
    }
}
