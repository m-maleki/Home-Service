using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public OrderRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<OrderDto>> GetAll()
            => _mapper.Map<List<OrderDto>>(await _context.Orders.ToListAsync());

        public async Task<OrderDto> GetBy(int id)
            => await _mapper.ProjectTo<OrderDto>(_context.Orders).Where(x => x.Id == id).SingleOrDefaultAsync();

        public async Task Create(OrderDto entity)
        {
            var record = _mapper.Map<Order>(entity);
            await _context.Orders.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task Update(OrderDto entity)
        {
            var record = await _mapper.ProjectTo<OrderDto>(_context.Set<OrderDto>())
                 .Where(x => x.Id == entity.Id).SingleOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
    }
}
