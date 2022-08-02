using AutoMapper;
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

        public async Task<List<OrderDto>> GetAllForExpert(CancellationToken cancellationToken)
        {
            var records = await _context.Orders
                .AsNoTracking()
                .Include(x => x.Customer)
                .Include(x => x.HomeService)

                .ToListAsync(cancellationToken);
            return _mapper.Map<List<OrderDto>>(records);
        }
        public async Task<List<OrderDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _context.Orders
                .AsNoTracking()
                .Include(x => x.Customer)
                .Include(x => x.HomeService)
                .Include(x=>x.Suggestions)
                .ThenInclude(x=>x.Expert)
                .ToListAsync(cancellationToken);
            return _mapper.Map<List<OrderDto>>(records);
        }
        public async Task<OrderDto> GetBy(int orderId, CancellationToken cancellationToken)
            => await _mapper.ProjectTo<OrderDto>( _context.Orders
            .AsNoTracking()
            .Include(x => x.Customer)
            .Include(x=>x.OrderFiles)
            .Include(x => x.HomeService)
            .ThenInclude(x=>x.Experts))
            .Where(x => x.Id == orderId)
            .FirstOrDefaultAsync(cancellationToken);
        public async Task<int> Create(OrderDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Order>(entity);
            record.RegisterDate = DateTime.Now;
            record.Status = OrderStatusEnum.WaitingExpertAdvice;
            await _context.Orders.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
            return record.Id;
        }
        public async Task addOrderFiles(List<OrderFileDto> dto, int orderId, CancellationToken cancellationToken)
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
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task Update(OrderDto entity, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<OrderDto>(_context.Set<OrderDto>())
                 .Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum, CancellationToken cancellationToken)
        {
            var orderStatus =await _context.Orders
            .Where(x => x.Id == orderId)
            .FirstOrDefaultAsync();
            orderStatus.Status = orderStatusEnum;
            await _context.SaveChangesAsync(cancellationToken);

        }
        public async Task<OrderStatusEnum> GetOrderStatusEnum(int orderId, CancellationToken cancellationToken)
        {
           return await _context.Orders
            .AsNoTracking()
            .Where(x => x.Id == orderId)
            .Select(x => x.Status)
            .FirstOrDefaultAsync(cancellationToken);
        }
        public async Task SoftDelete(int orderId, CancellationToken cancellationToken)
        {
            var order =await _context.Orders
                .Where(x=>x.Id== orderId)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task SoftRecover(int orderId, CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .Where(x => x.Id == orderId)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = false;
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task HardDelete(int orderId, CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .Where(x => x.Id == orderId)
                .FirstOrDefaultAsync(cancellationToken);
            _context.Remove(order);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> Count(CancellationToken cancellationToken)
        {
           return await _context.Orders.AsNoTracking().CountAsync(cancellationToken);
        }
    }
}
