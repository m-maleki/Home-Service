﻿using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Domain.Core.Enums;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class OrdersRepository : IOrderRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public OrdersRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<OrderDto>> GetAllForExpert()
        {
            var records = await _context.Orders
                .Include(x => x.Customer)
                .Include(x => x.HomeService)
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<OrderDto>>(records);
        }

        public async Task<List<OrderDto>> GetAll()
        {
            var records = await _context.Orders
                .Include(x => x.Customer)
                .Include(x => x.HomeService)
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<OrderDto>>(records);
        }


        public async Task<OrderDto> GetBy(int id)
            => await _mapper.ProjectTo<OrderDto>(_context.Orders)
            .Include(x => x.Customer)
            .Include(x => x.HomeService)
            .Where(x => x.Id == id)
            .AsNoTracking()
            .SingleOrDefaultAsync();

        public async Task<int> Create(OrderDto entity)
        {
            var record = _mapper.Map<Order>(entity);
            record.RegisterDate = DateTime.Now;
            record.Status = OrderStatusEnum.WaitingSpecialistSelection;
            await _context.Orders.AddAsync(record);
            await _context.SaveChangesAsync();
            return record.Id;
        }

        public async Task addOrderFiles(List<OrderFileDto> dto, int orderId)
        {
            foreach (var file in dto)
            {
                OrderFile productFile = new OrderFile
                {
                    OrderId=orderId,
                    Name = file.Name,
                    CreationDate = DateTime.Now,
                    IsDeleted = false,
                };
                _context.OrderFiles.Add(productFile);
            }
            await _context.SaveChangesAsync();
        }

        public async Task Update(OrderDto entity)
        {
            var record = await _mapper.ProjectTo<OrderDto>(_context.Set<OrderDto>())
                 .Where(x => x.Id == entity.Id).SingleOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }

        public async Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum)
        {
            var orderStatus =await _context.Orders
            .Where(x => x.Id == orderId)
            .SingleAsync();
            orderStatus.Status = orderStatusEnum;
            _context.SaveChangesAsync();

        }

        public async Task<OrderStatusEnum> GetOrderStatusEnum(int orderId)
        {
           return await _context.Orders
            .AsNoTracking()
            .Where(x => x.Id == orderId)
            .Select(x => x.Status)
            .SingleAsync();
        }
    }
}
