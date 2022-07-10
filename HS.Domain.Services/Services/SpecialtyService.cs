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
    public class SpecialtyService : ISpecialtyService
    {
        private readonly ISpecialtyRepository _specialtyRepository;

        public SpecialtyService(ISpecialtyRepository specialtyRepository)
        {
            _specialtyRepository = specialtyRepository;
        }

        public async Task Create(Specialty entity)
        {
            await _specialtyRepository.Create(entity);
        }

        public async Task Update(Specialty entity)
        {
            await _specialtyRepository.Update(entity);
        }

        public async Task<bool> Exists(int Id)
         => await _specialtyRepository.Exists(x => x.Id == Id);
        public async Task<bool> Exists(string Name)
         => await _specialtyRepository.Exists(x => x.Name == Name);
        public async Task<Specialty> Get(int Id)
         => await _specialtyRepository.Get(Id);
        public async Task<List<Specialty>> Get()
         => await _specialtyRepository.Get();
    }
}
