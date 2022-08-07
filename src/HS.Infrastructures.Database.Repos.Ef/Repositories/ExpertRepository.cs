using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class ExpertRepository : IExpertRepository
    {
        private readonly HSDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ExpertRepository> _loger;

        public ExpertRepository(HSDbContext context, IMapper mapper,ILogger<ExpertRepository> loger)
        {
            _context = context;
            _mapper = mapper;
            _loger = loger;
        }

        public async Task<int> Count(CancellationToken cancellationToken )
        {
            return await _context.Experts.AsNoTracking()
                .CountAsync(cancellationToken);
        }

        public async Task<List<ExpertDto>> GetAll(CancellationToken cancellationToken)
          => _mapper.Map<List<ExpertDto>>(await _context.Experts
              .AsNoTracking()
              .Include(x=>x.HomeServices)
              .ToListAsync(cancellationToken));

        public async Task<List<ExpertDto>> GetAll(Guid id, CancellationToken cancellationToken)
         => _mapper.Map<List<ExpertDto>>(await _context.Experts
              .AsNoTracking()
              .Include(x => x.HomeServices)
              .Where(x=>x.Id==id)
              .ToListAsync(cancellationToken));

        public async Task<ExpertDto> GetBy(Guid id, CancellationToken cancellationToken)
          => await _mapper.ProjectTo<ExpertDto>(_context.Experts
              .AsNoTracking()
              .Include(x=>x.HomeServices))
              .Where(x => x.Id == id)
              .FirstOrDefaultAsync(cancellationToken);

        public async Task Create(ExpertDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Expert>(entity);
            try
            {
                await _context.Experts.AddAsync(record);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch(Exception ex)
            {
                _loger.LogError("Error in add new expert {exception}", ex);
            }
        }

        public async Task Update(ExpertDto entity, CancellationToken cancellationToken)
        {
            var record = await _context.Experts
               .Include(x => x.HomeServices)
               .Where(x => x.Id == entity.Id)
               .FirstOrDefaultAsync(cancellationToken);

                record.HomeServices.Clear();

            try
            {
                foreach (var item in entity.HomeServicesIds)
                    record.HomeServices.Add(await _context.HomeServices.FirstOrDefaultAsync(x => x.Id == item));
                record = _mapper.Map(entity, record);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch(Exception ex)
            {
                _loger.LogError("Error in update expert {exception}", ex);

            }

        }


        public async Task<Guid> GetExpertId(Guid expertIdentityId, CancellationToken cancellationToken)
            => await _context.Experts
                .Where(x => x.ApplicationUserId == expertIdentityId)
                .Select(x => x.Id)
                .FirstOrDefaultAsync(cancellationToken);

        public async Task<List<OrderDto>> GetAllBy(Guid expertId, CancellationToken cancellationToken)
        {
            List<Order> result = new List<Order>();
            var expertHomeService = await _context.Experts
                .Include(x => x.HomeServices)
                .Where(x => x.Id == expertId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            var orders = await _context.Orders
                .Include(x => x.Customer)
                .Include(x => x.HomeService)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            foreach (var expertService in expertHomeService.HomeServices)
            {
                foreach (var order in orders)
                {
                    if (expertService.Name == order.HomeService.Name)
                        result.Add(order);
                }
            }

            return _mapper.Map<List<OrderDto>>(result);
        }
    }
}
