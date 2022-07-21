using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class HomeServiceRepository :  IHomeServiceRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public HomeServiceRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<HomeServiceDto>> GetAll()
            => _mapper.Map<List<HomeServiceDto>>(await _context.HomeServices
                .AsNoTracking()
                .ToListAsync());
        public async Task<HomeServiceDto> GetBy(int id)
        {
            var record = await _context.HomeServices
                .AsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map(record, new HomeServiceDto());
        }
        public async Task Create(HomeServiceDto entity)
        {
            var record = _mapper.Map<HomeService>(entity);
            await _context.HomeServices.AddAsync(record);
            await _context.SaveChangesAsync();
        }
        public async Task Update(HomeServiceDto entity)
        {
            var record = await _mapper.ProjectTo<HomeServiceDto>(_context.Set<HomeServiceDto>())
                 .Where(x => x.Id == entity.Id)
                 .FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
        public Task<List<HomeServiceDto>> GetAll(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
