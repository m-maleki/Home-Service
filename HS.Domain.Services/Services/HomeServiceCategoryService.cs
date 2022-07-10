using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services.Services
{
    public class HomeServiceCategoryService : IHomeServiceCategoryService
    {
        private readonly IHomeServiceCategoryRepository _homeServiceCategoryRepository;
        public HomeServiceCategoryService(IHomeServiceCategoryRepository homeServiceCategoryRepository)
        {
            _homeServiceCategoryRepository = homeServiceCategoryRepository;
        }

        public async Task Create(HomeServiceCategory entity)
        {
            await _homeServiceCategoryRepository.Create(entity);
        }

        public async Task Update(HomeServiceCategory entity)
        {
            await _homeServiceCategoryRepository.Update(entity);
        }

        public async Task<bool> Exists(int Id)
         => await _homeServiceCategoryRepository.Exists(x => x.Id == Id);
        public async Task<bool> Exists(string Name)
         => await _homeServiceCategoryRepository.Exists(x => x.Name == Name);
        public async Task<HomeServiceCategory> Get(int Id)
         => await _homeServiceCategoryRepository.Get(Id);
        public async Task<List<HomeServiceCategory>> Get()
         => await _homeServiceCategoryRepository.Get();

    }
}
