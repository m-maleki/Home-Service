using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Enums;
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
        private readonly IOrderService _orderService;
        private readonly IExpertService _expertService;
        private readonly IApplicationUserApplicationService _userApplicationService;
        public SuggestionApplicationService(ISuggestionService suggestionService,
            IExpertService expertService,
            IOrderService orderService,
            IApplicationUserApplicationService userApplicationService)
        {
            _suggestionService = suggestionService;
            _expertService = expertService;
            _orderService = orderService;
            _userApplicationService = userApplicationService;
        }

        public async Task Accept(int suggestionId, int orderId)
        {
            await _suggestionService.Accept(suggestionId);
            await _orderService.SetOrderStatusEnum(orderId, OrderStatusEnum.WaitingSpecialistComeToYourPlace);
        }

        public async Task<int> Count()
        {
            return await _suggestionService.Count();
        }

        public async Task Create(SuggestionDto entity)
        {
            PersianCalendar pc = new PersianCalendar();
            entity.DurationOfWork = new DateTime(entity.DurationOfWork.Year, entity.DurationOfWork.Month, entity.DurationOfWork.Day, pc);
            entity.RegisterDate = DateTime.Now;
            entity.ExpertId =  await _expertService.GetExpertId(_userApplicationService.GetUserId());
            await _suggestionService.Create(entity);
            var suggestionCount = await _suggestionService.GetCount(entity.OrderId);
            if (suggestionCount == 1)
            {
                await _orderService.SetOrderStatusEnum(entity.OrderId, OrderStatusEnum.WaitingSpecialistSelection);
            }
        }

        public Task EnsureDoesNotExist(int Id)
        {
            return _suggestionService.EnsureDoesNotExist(Id);
        }

        public Task EnsureExists(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EnsureExistSuggestion(int orderId)
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
