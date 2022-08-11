using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class HomeServiceRepository :  IHomeServiceRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;
        private readonly ILogger<HomeServiceRepository> _loger;

        public HomeServiceRepository(HSDbContext context,
            IMapper mapper,
            ILogger<HomeServiceRepository> loger)
        {
            _context = context;
            _mapper = mapper;
            _loger = loger;
        }
        public async Task<List<HomeServiceDto>> GetAll(CancellationToken cancellationToken)
            => _mapper.Map<List<HomeServiceDto>>(await _context.HomeServices
                .AsNoTracking()
              //  .Where(x=>x.IsDeleted==false)
                .Include(x=>x.HomeServiceSubCategory)
                .ToListAsync(cancellationToken));

        public async Task<List<HomeServiceDto>> GetAll(int subCategoryId, CancellationToken cancellationToken)
           => _mapper.Map<List<HomeServiceDto>>(await _context.HomeServices
               .AsNoTracking()
               .Include(x=>x.HomeServiceSubCategory)
               .Where(x=>x.HomeServiceSubCategoryId== subCategoryId && x.IsDeleted==false)
               .ToListAsync(cancellationToken));

        public async Task<HomeServiceDto> GetBy(int id, CancellationToken cancellationToken)
        {
            var record = await _context.HomeServices
                .AsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync(cancellationToken);
            return _mapper.Map(record, new HomeServiceDto());
        }

        public async Task Create(HomeServiceDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<HomeService>(entity);
            await _context.HomeServices.AddAsync(record);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _loger.LogError("Error in add new HomeService {exception}", ex);
            }
        }
        public async Task Update(HomeServiceDto entity, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<HomeServiceDto>(_context.Set<HomeServiceDto>())
                 .Where(x => x.Id == entity.Id)
                 .FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _loger.LogError("Error in update HomeService {exception}", ex);
            }
        }
        public Task<List<HomeServiceDto>> GetAll(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Active(int id, CancellationToken cancellationToken)
        {
            var record = await _context.HomeServices
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            record.IsDeleted = false;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int id, CancellationToken cancellationToken)
        {
            var record = await _context.HomeServices
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            record.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<HomeServiceDto>> Search(string keyword,CancellationToken cancellationToken)
             => _mapper.Map<List<HomeServiceDto>>(await _context.HomeServices
               .AsNoTracking()
               .Include(x => x.HomeServiceSubCategory)
               .Where(x => x.Name.Contains(keyword))
               .ToListAsync(cancellationToken));
    }
}
