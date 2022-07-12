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
            => _mapper.Map<List<HomeServiceDto>>(await _context.HomeServices.ToListAsync());

        public async Task<HomeServiceDto> GetBy(int id)
            => await _mapper.ProjectTo<HomeServiceDto>(_context.HomeServices).Where(x => x.Id == id).SingleOrDefaultAsync();

        public async Task Create(HomeServiceDto entity)
        {
            var record = _mapper.Map<HomeService>(entity);
            await _context.HomeServices.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task Update(HomeServiceDto entity)
        {
            var record = await _mapper.ProjectTo<HomeServiceDto>(_context.Set<HomeServiceDto>())
                 .Where(x => x.Id == entity.Id).SingleOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
    }
}
