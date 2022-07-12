using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ISpecialtyRepository
    {
        Task<SpecialtyDto> GetBy(int id);
        Task<List<SpecialtyDto>> GetAll();
        Task Create(SpecialtyDto entity);
        Task Update(SpecialtyDto entity);
    }
}
