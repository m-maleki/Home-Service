using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class HomeServiceSubCategoryApplicationService : IHomeServiceSubCategoryApplicationService
    {
        private readonly IHomeServiceSubCategoryService _homeServiceSubCategoryService;

        public HomeServiceSubCategoryApplicationService(IHomeServiceSubCategoryService homeServiceSubCategoryService)
        {
            _homeServiceSubCategoryService = homeServiceSubCategoryService;
        }

        public Task Create(HomeServiceSubCategoryDto entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<HomeServiceSubCategoryDto>> GetAll()
        {
            return await _homeServiceSubCategoryService.GetAll();
        }

        public async Task<List<HomeServiceSubCategoryDto>> GetAllBy(int homeServiceCategoryId)
        {
           return await (_homeServiceSubCategoryService.GetAllBy(homeServiceCategoryId));
        }

        public Task<HomeServiceSubCategoryDto> GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public Task<HomeServiceSubCategoryDto> GetBy(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(HomeServiceSubCategoryDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
