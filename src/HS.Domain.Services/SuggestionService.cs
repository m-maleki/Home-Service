﻿using HS.Domain.Core.Contracts.Repository;
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

        public async Task Accept(int suggestionId)
        {
            await _suggestionRepository.Accept(suggestionId);
        }

        public async Task Create(SuggestionDto entity)
        {
            await _suggestionRepository.Create(entity);
        }

        public Task EnsureDoesNotExist(int Id)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EnsureExistSuggestion(int orderId)
        {
            return await _suggestionRepository.EnsureExistSuggestion(orderId);
        }

        public Task<SuggestionDto> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuggestionDto>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> GetAcceptSuggestionExpertId(int orderId)
        {
          return  await _suggestionRepository.GetAcceptSuggestionExpertId(orderId);
        }

        public async Task<List<SuggestionDto>> GetAll(int orderId)
        {
            return await _suggestionRepository.GetAll(orderId);
        }

        public async Task<int> GetCount(int orderId)
        {
            return await _suggestionRepository.GetCount(orderId);
        }

        public Task Update(SuggestionDto entity)
        {
            throw new NotImplementedException();
        }
    }
}