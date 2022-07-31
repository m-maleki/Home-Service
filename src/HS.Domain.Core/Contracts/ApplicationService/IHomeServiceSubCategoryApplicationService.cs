using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface IHomeServiceSubCategoryApplicationService
    {
        Task<HomeServiceSubCategoryDto> GetBy(int id);
        Task<HomeServiceSubCategoryDto> GetBy(string name);
        Task<List<HomeServiceSubCategoryDto>> GetAll();
        Task Create(HomeServiceSubCategoryDto entity);
        Task Update(HomeServiceSubCategoryDto entity);
        Task<List<HomeServiceSubCategoryDto>> GetAllBy(int homeServiceCategoryId);
    }
}
