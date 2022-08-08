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
        private readonly ISmsService _smsService;
        private readonly IEmailService _emailService;
        public SuggestionApplicationService(ISuggestionService suggestionService,
            IExpertService expertService,
            IOrderService orderService,
            IApplicationUserApplicationService userApplicationService,
            ISmsService smsService,
            IEmailService emailService)
        {
            _suggestionService = suggestionService;
            _expertService = expertService;
            _orderService = orderService;
            _userApplicationService = userApplicationService;
            _smsService = smsService;
            _emailService = emailService;
        }

        public async Task Accept(int suggestionId, int orderId, CancellationToken cancellationToken)
        {
            string message = "";
            await _suggestionService.Accept(suggestionId, cancellationToken);
            await _orderService.SetOrderStatusEnum(orderId, OrderStatusEnum.WaitingSpecialistComeToYourPlace, cancellationToken);
            var sugg =await _suggestionService.Get(suggestionId, cancellationToken);
            message = $"سلام. {sugg.Expert.FirstName + " " + sugg.Expert.LastName} عزیز، پیشنهاد شما با شماره {suggestionId} توسط کارفرما تایید شد.";
            if (sugg.Expert.PhoneNumber !=null)
            {
                await _smsService.Send(message, sugg.Expert.PhoneNumber);
            }
            if(sugg.Expert.ApplicationUser.Email !=null)
            {
               await _emailService.SendEmailAsync(sugg.Expert.ApplicationUser.Email, "تایید پیشنهاد توسط کارفرما", message);
            }

        }

        public async Task<int> Count(CancellationToken cancellationToken)
        {
            return await _suggestionService.Count(cancellationToken);
        }

        public async Task Create(SuggestionDto entity, CancellationToken cancellationToken)
        {
            PersianCalendar pc = new PersianCalendar();
            entity.DurationOfWork = new DateTime(entity.DurationOfWork.Year, entity.DurationOfWork.Month, entity.DurationOfWork.Day, pc);
            entity.RegisterDate = DateTime.Now;
            entity.ExpertId =  await _expertService.GetExpertId(_userApplicationService.GetUserId(cancellationToken), cancellationToken);
            await _suggestionService.Create(entity, cancellationToken);
            var suggestionCount = await _suggestionService.GetCount(entity.OrderId, cancellationToken);
            if (suggestionCount == 1)
            {
                await _orderService.SetOrderStatusEnum(entity.OrderId, OrderStatusEnum.WaitingSpecialistSelection, cancellationToken);
            }
        }

        public Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken)
        {
            return _suggestionService.EnsureDoesNotExist(Id, cancellationToken);
        }

        public Task EnsureExists(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EnsureExistSuggestion(int orderId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<SuggestionDto> Get(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SuggestionDto>> Get(CancellationToken cancellationToken)
        {
            return await _suggestionService.Get(cancellationToken);
        }

        public async Task<List<SuggestionDto>> GetAll(int orderId, CancellationToken cancellationToken)
        {
            return await _suggestionService.GetAll(orderId, cancellationToken);
        }

        public async Task<int> GetCount(int orderId, CancellationToken cancellationToken)
        {
            return await _suggestionService.GetCount(orderId, cancellationToken);
        }

        public Task Update(SuggestionDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
