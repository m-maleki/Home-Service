using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class OrderApplicationService : IOrderApplicationService
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IExpertService _expertService;
        private readonly IApplicationUserService _applicationUserService;
        public OrderApplicationService(IOrderService orderService,
            ICustomerService customerService,
            IExpertService expertService,
            IApplicationUserService applicationUserService)
        {
            _orderService = orderService;
            _customerService = customerService;
            _expertService = expertService;
            _applicationUserService = applicationUserService;
        }

        public async Task<int> Count(CancellationToken cancellationToken)
        {
            return await _orderService.Count(cancellationToken);
        }

        public async Task Create(OrderDto entity, List<IFormFile> FormFile,CancellationToken cancellationToken)
        {
            entity.CustomerId= await _customerService.GetCustomerId(_applicationUserService.GetUserId(cancellationToken), cancellationToken);
            PersianCalendar pc = new PersianCalendar();
            TimeSpan time = new TimeSpan(int.Parse(entity.Clock.Substring(0,2)), int.Parse(entity.Clock.Substring(3, 2)),0);
            entity.DateOfExecution = new DateTime(entity.DateOfExecution.Year, entity.DateOfExecution.Month, entity.DateOfExecution.Day,  pc);
            entity.DateOfExecution =  entity.DateOfExecution.Add(time);
            entity.currentApplicationUserID = _applicationUserService.GetUserId(cancellationToken).ToString();
            var orderId = await _orderService.Create(entity, cancellationToken);
            if(FormFile !=null)
            {
            var files = await _orderService.UploadFiles(FormFile, orderId);
            await _orderService.SetOrderFiles(files, orderId, cancellationToken);
            }
        }

        public async Task<OrderDto> Get(int Id, CancellationToken cancellationToken)
         => await  _orderService.Get(Id, cancellationToken);

        public async Task<List<OrderDto>> Get(CancellationToken cancellationToken)
         => await _orderService.Get(cancellationToken);

        public async Task<List<OrderDto>> GetAll(CancellationToken cancellationToken)
        {
             var role = await _applicationUserService.getRole(cancellationToken);

            if (role=="Expert")
            {
                var expertCustomerid = await _expertService.GetExpertId(_applicationUserService.GetUserId(cancellationToken), cancellationToken);
                return await _expertService.GetAllBy(expertCustomerid, cancellationToken);
            }
            else if(role == "Customer")
            {
                var customerid = await _customerService.GetCustomerId(_applicationUserService.GetUserId(cancellationToken), cancellationToken);
                return await _customerService.GetAllBy(customerid, cancellationToken);
            }
            else if (role == "Admin")
            {
                return await _orderService.Get(cancellationToken);
            }
            return default;
        }

        public async Task<OrderDto> GetBy(int orderId, CancellationToken cancellationToken)
        {
           return await _orderService.GetBy(orderId, cancellationToken);
        }

        public async Task<OrderStatusEnum> GetOrderStatusEnum(int orderId, CancellationToken cancellationToken)
        {
            return await _orderService.GetOrderStatusEnum(orderId, cancellationToken);
        }

        public async Task HardDelete(int orderId, CancellationToken cancellationToken)
        {
            await _orderService.HardDelete(orderId, cancellationToken);
        }

        public async Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum, CancellationToken cancellationToken)
        {
            await _orderService.SetOrderStatusEnum(orderId, orderStatusEnum, cancellationToken);
        }

        public async Task SoftDelete(int orderId, CancellationToken cancellationToken)
        {
            await _orderService.SoftDelete(orderId, cancellationToken);
        }

        public async Task SoftRecover(int orderId, CancellationToken cancellationToken)
        {
            await _orderService.SoftRecover(orderId, cancellationToken);
        }

        public Task Update(OrderDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
