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
    public class HomeServiceService : IHomeServiceService
    {
        private readonly IHomeServiceRepository _homeServiceRepository;
        public HomeServiceService(IHomeServiceRepository homeServiceRepository)
        {
            _homeServiceRepository = homeServiceRepository;
        }
        public async Task Create(HomeService entity)
        {
            await _homeServiceRepository.Create(entity);
        }
        public async Task Update(HomeService entity)
        {
            await _homeServiceRepository.Update(entity);
        }
        public async Task<HomeService> Get(int Id)
         => await _homeServiceRepository.Get(Id);
        public async Task<List<HomeService>> Get()
         => await _homeServiceRepository.Get();
        public async Task EnsureExists(int Id)
        {
            if (await _homeServiceRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"HomeService with id : {Id} Not Exist !");
        }
        public async Task EnsureExists(string Name)
        {
            if (await _homeServiceRepository.Exists(x => x.Name == Name) == false)
                throw new Exception($"HomeService with Name : {Name} Not Exist !");
        }
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _homeServiceRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a HomeService with id = {Id}");
        }
        public async Task EnsureDoesNotExist(string Name)
        {
            if (await _homeServiceRepository.Exists(x => x.Name == Name) == true)
                throw new Exception($"there is already a HomeService with Name = {Name}");
        }
    }
}