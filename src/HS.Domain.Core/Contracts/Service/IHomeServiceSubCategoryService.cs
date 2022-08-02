using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IHomeServiceSubCategoryService
    {
        Task<HomeServiceSubCategoryDto> GetBy(int id,CancellationToken cancellationToken);
        Task<HomeServiceSubCategoryDto> GetBy(string name, CancellationToken cancellationToken);
        Task<List<HomeServiceSubCategoryDto>> GetAll(CancellationToken cancellationToken);
        Task Create(HomeServiceSubCategoryDto entity, CancellationToken cancellationToken);
        Task Update(HomeServiceSubCategoryDto entity, CancellationToken cancellationToken);
        Task<List<HomeServiceSubCategoryDto>> GetAllBy(int homeServiceCategoryId, CancellationToken cancellationToken);
    }
}
