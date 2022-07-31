using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class HomeServiceCategoryService : IHomeServiceCategoryService
    {
        private readonly IHomeServiceCategoryRepository _homeServiceCategoryRepository;

        public HomeServiceCategoryService(IHomeServiceCategoryRepository homeServiceCategoryRepository)
        {
            _homeServiceCategoryRepository = homeServiceCategoryRepository;
        }

        public async Task<List<HomeServiceCategoryDto>> GetAll()
        {
            return await _homeServiceCategoryRepository.GetAll();
        }
    }
}
