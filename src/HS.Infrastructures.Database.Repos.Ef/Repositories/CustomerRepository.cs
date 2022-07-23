using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly HSDbContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<CustomerDto>> GetAll()
          => _mapper.Map<List<CustomerDto>>(await _context.Customers
              .AsNoTracking()
              .ToListAsync());
        public async Task<CustomerDto> GetBy(Guid id)
          => await _mapper.ProjectTo<CustomerDto>(_context.Customers)
            .AsNoTracking()
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();
        public async Task<CustomerDto> GetBy(string mobileNumber)
          => await _mapper.ProjectTo<CustomerDto>(_context.Customers)
            .Where(x => x.MobileNumber == mobileNumber)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        public async Task Create(CustomerDto entity)
        {
            var record = _mapper.Map<Customer>(entity);
            await _context.Customers.AddAsync(record);
            await _context.SaveChangesAsync();
        }
        public async Task Update(CustomerDto entity)
        {
            var record = await _context.Customers
                .Where(x => x.Id == entity.Id)
                .FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
        public async Task<Guid> GetCustomerId(Guid CustomerIdentityId)
            => await _context.Customers
                .Where(x => x.ApplicationUserId == CustomerIdentityId)
                .Select(x=>x.Id)
                .FirstOrDefaultAsync();
        public async Task<List<OrderDto>> GetAllBy(Guid customerId)
        {
            var records = await _context.Orders
                .Include(x => x.Customer)
                .Include(x => x.HomeService)
                .Include(x=>x.Suggestions)
                .ThenInclude(x=>x.Expert)
                .Where(x => x.CustomerId == customerId && x.IsDeleted==false)
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<OrderDto>>(records);
        }
    }
}

