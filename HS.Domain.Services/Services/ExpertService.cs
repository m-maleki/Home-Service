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
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertServiceRepository;
        public ExpertService(IExpertRepository expertServiceRepository)
        {
            _expertServiceRepository = expertServiceRepository;
        }
        public async Task Create(Expert entity)
        {
            await _expertServiceRepository.Create(entity);
        }
        public async Task Update(Expert entity)
        {
            await _expertServiceRepository.Update(entity);
        }
        public async Task<Expert> Get(int Id)
         => await _expertServiceRepository.Get(Id);
        public async Task<List<Expert>> Get()
         => await _expertServiceRepository.Get();
        public async Task EnsureExists(int Id)
        {
            if (await _expertServiceRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"Expert with id : {Id} Not Exist !");
        }
        public async Task EnsureExists(string PhoneNumber)
        {
            if (await _expertServiceRepository.Exists(x => x.PhoneNumber == PhoneNumber) == false)
                throw new Exception($"Expert with phonenumber : {PhoneNumber} Not Exist !");
        }
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _expertServiceRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a Expert with id = {Id}");
        }
        public async Task EnsureDoesNotExist(string PhoneNumber)
        {
            if (await _expertServiceRepository.Exists(x => x.PhoneNumber == PhoneNumber) == true)
                throw new Exception($"there is already a Expert with PhoneNumber = {PhoneNumber}");
        }
    }
}