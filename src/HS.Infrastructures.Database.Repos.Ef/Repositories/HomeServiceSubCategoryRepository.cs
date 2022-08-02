using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class HomeServiceSubCategoryRepository : IHomeServiceSubCategoryRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public HomeServiceSubCategoryRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<HomeServiceSubCategoryDto>> GetAll(CancellationToken cancellationToken)
            => _mapper.Map<List<HomeServiceSubCategoryDto>>(await _context.HomeServiceSubCategories
                .AsNoTracking()
                .ToListAsync(cancellationToken));

        public async Task<List<HomeServiceSubCategoryDto>> GetAllBy(int homeServiceCategoryId, CancellationToken cancellationToken)
        => await _mapper.ProjectTo<HomeServiceSubCategoryDto>(_context.HomeServiceSubCategories
        .Include(x=>x.HomeServices))
        .Where(x => x.HomeServiceCategoryId == homeServiceCategoryId)
        .ToListAsync(cancellationToken);

        public async Task<HomeServiceSubCategoryDto> GetBy(int id, CancellationToken cancellationToken)
            => await _mapper.ProjectTo<HomeServiceSubCategoryDto>(_context.HomeServiceSubCategories)
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync(cancellationToken);
        public async Task Create(HomeServiceSubCategoryDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<HomeServiceSubCategory>(entity);
            await _context.HomeServiceSubCategories.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task Update(HomeServiceSubCategoryDto entity, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<HomeServiceSubCategoryDto>(_context.Set<HomeServiceSubCategoryDto>())
                 .Where(x => x.Id == entity.Id).SingleOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task<HomeServiceSubCategoryDto> GetBy(string name, CancellationToken cancellationToken)
            => await _mapper.ProjectTo<HomeServiceSubCategoryDto>(_context.HomeServiceSubCategories)
            .AsNoTracking()
            .Where(x => x.Name == name)
            .FirstOrDefaultAsync(cancellationToken);
    }
}
