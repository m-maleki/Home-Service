using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class SuggestionApplicationService : ISuggestionApplicationService
    {
        private readonly ISuggestionService _suggestionService;
        private readonly IExpertService _expertService;
        public SuggestionApplicationService(ISuggestionService suggestionService,
            IExpertService expertService)
        {
            _suggestionService = suggestionService;
            _expertService = expertService;
        }

        public async Task Create(SuggestionDto entity)
        {
            PersianCalendar pc = new PersianCalendar();
            entity.DurationOfWork = new DateTime(entity.DurationOfWork.Year, entity.DurationOfWork.Month, entity.DurationOfWork.Day, pc);
            entity.RegisterDate = DateTime.Now;
            entity.ExpertId =  await _expertService.GetExpertId(entity.ExpertId);

            await _suggestionService.Create(entity);
        }

        public Task EnsureDoesNotExist(int Id)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<SuggestionDto> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuggestionDto>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<List<SuggestionDto>> GetAll(int orderId)
        {
            return await _suggestionService.GetAll(orderId);
        }

        public async Task<int> GetCount(int orderId)
        {
            return await _suggestionService.GetCount(orderId);
        }

        public Task Update(SuggestionDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
