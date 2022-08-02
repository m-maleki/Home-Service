using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class OrderFileRepository : IOrderFileRepository
    {
        private readonly HSDbContext _context;
        private readonly IMapper _mapper;

        public OrderFileRepository(HSDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task DeleteFile(int fileId, CancellationToken cancellationToken)
        {
            var record = await _context.OrderFiles
            .Where(x => x.Id == fileId)
            .SingleAsync(cancellationToken);
            _context.OrderFiles.Remove(record);
            _context.SaveChangesAsync(cancellationToken);
        }
        public async Task<OrderFileDto> Get(int fileId, CancellationToken cancellationToken)
        {
              return await _mapper.ProjectTo<OrderFileDto>(_context.OrderFiles
            .AsNoTracking())
            .Where(x => x.Id == fileId)
            .FirstOrDefaultAsync(cancellationToken);
        }
        public async Task<List<OrderFileDto>> GetAll(int orderId, CancellationToken cancellationToken)
        {
            var records = await _context.OrderFiles
                .AsNoTracking()
                .Where(x => x.OrderId == orderId)
                .ToListAsync(cancellationToken);
            return _mapper.Map<List<OrderFileDto>>(records);
        }
    }
}
