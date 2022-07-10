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
        public async Task<HomeServiceCategory> Get(int Id)
         => await _homeServiceCategoryRepository.Get(Id);
        public async Task<List<HomeServiceCategory>> Get()
         => await _homeServiceCategoryRepository.Get();
        public async Task EnsureExists(int Id)
        {
            if (await _homeServiceCategoryRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"HomeServiceCategory with id : {Id} Not Exist !");
        }
        public async Task EnsureExists(string Name)
        {
            if (await _homeServiceCategoryRepository.Exists(x => x.Name == Name) == false)
                throw new Exception($"HomeServiceCategory with Name : {Name} Not Exist !");
        }
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _homeServiceCategoryRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a HomeServiceCategory with id = {Id}");
        }
        public async Task EnsureDoesNotExist(string Name)
        {
            if (await _homeServiceCategoryRepository.Exists(x => x.Name == Name) == true)
                throw new Exception($"there is already a HomeServiceCategory with Name = {Name}");
        }
    }
}