using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class HomeServiceCategoryRepository : IHomeServiceCategoryRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public HomeServiceCategoryRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<List<HomeServiceCategoryDto>> GetAll(CancellationToken cancellationToken)
            => _mapper.Map<List<HomeServiceCategoryDto>>(await _context.HomeServiceCategories
                .Include(x=>x.HomeServiceSubCategories)
                .ThenInclude(x=>x.HomeServices)
                .AsNoTracking()
                .ToListAsync());
        public async Task<HomeServiceCategoryDto> GetBy(int id, CancellationToken cancellationToken)
            => await _mapper.ProjectTo<HomeServiceCategoryDto>(_context.HomeServiceCategories)
            .Where(x => x.Id == id).FirstOrDefaultAsync(cancellationToken);
        public async Task<HomeServiceCategoryDto> GetBy(string name, CancellationToken cancellationToken)
           => await _mapper.ProjectTo<HomeServiceCategoryDto>(_context.HomeServiceCategories)
        .Where(x => x.Name == name).FirstOrDefaultAsync(cancellationToken);
        public async Task Create(HomeServiceCategoryDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<HomeServiceCategory>(entity);
            await _context.HomeServiceCategories.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task Update(HomeServiceCategoryDto entity, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<HomeServiceCategoryDto>(_context.Set<HomeServiceCategoryDto>())
                 .Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}
