using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class SuggestionService : ISuggestionService
    {
        private readonly ISuggestionRepository _suggestionRepository;

        public SuggestionService(ISuggestionRepository suggestionRepository)
        {
            _suggestionRepository = suggestionRepository;
        }

        public async Task Accept(int suggestionId, CancellationToken cancellationToken)
        {
            await _suggestionRepository.Accept(suggestionId, cancellationToken);
        }

        public async Task Create(SuggestionDto entity, CancellationToken cancellationToken)
        {
            await _suggestionRepository.Create(entity, cancellationToken);
        }

        public Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Task EnsureExists(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Task Update(SuggestionDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> EnsureExistSuggestion(int orderId, CancellationToken cancellationToken)
            => await _suggestionRepository.EnsureExistSuggestion(orderId, cancellationToken);

        public async Task<SuggestionDto> Get(int Id, CancellationToken cancellationToken)
           => await _suggestionRepository.GetBy(Id, cancellationToken);

        public async Task<List<SuggestionDto>> Get(CancellationToken cancellationToken)
            => await _suggestionRepository.GetAll(cancellationToken);

        public async Task<Guid> GetAcceptSuggestionExpertId(int orderId, CancellationToken cancellationToken)
           =>  await _suggestionRepository.GetAcceptSuggestionExpertId(orderId, cancellationToken);

        public async Task<List<SuggestionDto>> GetAll(int orderId, CancellationToken cancellationToken)
            => await _suggestionRepository.GetAll(orderId, cancellationToken);

        public async Task<int> GetCount(int orderId, CancellationToken cancellationToken)
            => await _suggestionRepository.GetCount(orderId, cancellationToken);
        public async Task<int> Count(CancellationToken cancellationToken)
          => await _suggestionRepository.Count(cancellationToken);

    }
}
