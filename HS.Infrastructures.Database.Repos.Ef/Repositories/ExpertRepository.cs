using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class ExpertRepository : IExpertRepository
    {
        private readonly HSDbContext _context;
        private readonly IMapper _mapper;

        public ExpertRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ExpertDto>> GetAll()
          => _mapper.Map<List<ExpertDto>>(await _context.Experts.AsNoTracking().ToListAsync());

        public async Task<ExpertDto> GetBy(Guid id)
          => await _mapper.ProjectTo<ExpertDto>(_context.Experts.AsNoTracking().Include(x=>x.HomeServices))
            .AsNoTracking()
            .Where(x => x.ApplicationUserId == id)
            .FirstOrDefaultAsync();

        public async Task Create(ExpertDto entity)
        {
            var record = _mapper.Map<Expert>(entity);
            await _context.Experts.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ExpertDto entity)
        {
            var record = await _context.Experts
               .Include(x => x.HomeServices)
               .Where(x => x.Id == entity.Id)
               .SingleOrDefaultAsync();
                record.HomeServices.Clear();


            foreach (var item in entity.HomeServicesIds)
                record.HomeServices.Add(await _context.HomeServices.FirstOrDefaultAsync(x => x.Id == item));

            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }

    }
}
