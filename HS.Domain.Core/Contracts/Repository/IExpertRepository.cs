using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IExpertRepository 
    {
        Task<ExpertDto> GetBy(int id);
        Task<ExpertDto> GetBy(string mobileNumber);
        Task<List<ExpertDto>> GetAll();
        Task Create(ExpertDto entity);
        Task Update(ExpertDto entity);
    }
}
