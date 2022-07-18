﻿using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IOrderService
    {
        Task<OrderDto> Get(int Id);
        Task<List<OrderDto>> Get();
        Task Create(OrderDto entity);
        Task Update(OrderDto entity);
        Task EnsureExists(int Id);
        Task EnsureDoesNotExist(int Id);
        Task<List<OrderDto>> GetAllBy(Guid customerId);

    }
}
