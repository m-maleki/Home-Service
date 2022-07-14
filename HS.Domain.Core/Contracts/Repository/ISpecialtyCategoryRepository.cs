using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ISpecialtyCategoryRepository
    {
        Task<SpecialtyCategoryDto> GetBy(int id);
        Task<SpecialtyCategoryDto> GetBy(string name);
        Task<List<SpecialtyCategoryDto>> GetAll();
        Task Create(SpecialtyCategoryDto entity);
        Task Update(SpecialtyCategoryDto entity);
    }
}
