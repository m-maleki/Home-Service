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
        public async Task<Specialty> Get(int Id)
         => await _specialtyRepository.Get(Id);
        public async Task<List<Specialty>> Get()
         => await _specialtyRepository.Get();
        public async Task EnsureExists(int Id)
        {
            if (await _specialtyRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"Specialty with id : {Id} Not Exist !");
        }
        public async Task EnsureExists(string Name)
        {
            if (await _specialtyRepository.Exists(x => x.Name == Name) == false)
                throw new Exception($"Specialty with Name : {Name} Not Exist !");
        }
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _specialtyRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a Specialty with id = {Id}");
        }
        public async Task EnsureDoesNotExist(string Name)
        {
            if (await _specialtyRepository.Exists(x => x.Name == Name) == true)
                throw new Exception($"there is already a Specialty with Name = {Name}");
        }
    }
}