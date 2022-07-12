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

        public async Task<List<HomeServiceCategoryDto>> GetAll()
            => _mapper.Map<List<HomeServiceCategoryDto>>(await _context.HomeServiceCategories.ToListAsync());

        public async Task<HomeServiceCategoryDto> GetBy(int id)
            => await _mapper.ProjectTo<HomeServiceCategoryDto>(_context.HomeServiceCategories)
            .Where(x => x.Id == id).SingleOrDefaultAsync();

        public async Task<HomeServiceCategoryDto> GetBy(string name)
           => await _mapper.ProjectTo<HomeServiceCategoryDto>(_context.HomeServiceCategories)
        .Where(x => x.Name == name).SingleOrDefaultAsync();

        public async Task Create(HomeServiceCategoryDto entity)
        {
            var record = _mapper.Map<HomeServiceCategory>(entity);
            await _context.HomeServiceCategories.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task Update(HomeServiceCategoryDto entity)
        {
            var record = await _mapper.ProjectTo<HomeServiceCategoryDto>(_context.Set<HomeServiceCategoryDto>())
                 .Where(x => x.Id == entity.Id).SingleOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }

    }
}
