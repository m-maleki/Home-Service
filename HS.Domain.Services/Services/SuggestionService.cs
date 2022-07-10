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
    public class SuggestionService : ISuggestionService
    {
        private readonly ISuggestionRepository _suggestionRepository;
        public SuggestionService(ISuggestionRepository suggestionRepository)
        {
            _suggestionRepository = suggestionRepository;
        }
        public async Task Create(Suggestion entity)
        {
            await _suggestionRepository.Create(entity);
        }
        public async Task Update(Suggestion entity)
        {
            await _suggestionRepository.Update(entity);
        }
        public async Task<bool> Exists(int Id)
         => await _suggestionRepository.Exists(x => x.Id == Id);
        public async Task<Suggestion> Get(int Id)
         => await _suggestionRepository.Get(Id);
        public async Task<List<Suggestion>> Get()
         => await _suggestionRepository.Get();
        public async Task EnsureExists(int Id)
        {
            if (await _suggestionRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"Suggestion with id : {Id} Not Exist !");
        }
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _suggestionRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a Suggestion with id = {Id}");
        }
    }
}