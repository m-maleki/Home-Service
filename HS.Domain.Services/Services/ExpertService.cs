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

        public async Task<bool> Exists(int Id)
         => await _expertServiceRepository.Exists(x=>x.Id==Id);

        public async Task<Expert> Get(int Id)
         => await _expertServiceRepository.Get(Id);

        public async Task<List<Expert>> Get()
         => await _expertServiceRepository.Get();
        public async Task<bool> Exists(string Firstname, string LastName)
         => await _expertServiceRepository.Exists(x => x.FirstName == Firstname && x.LastName == LastName);

        public async Task Exists(string PhoneNumber)
         => await _expertServiceRepository.Exists(x => x.PhoneNumber == PhoneNumber);

    }
}
