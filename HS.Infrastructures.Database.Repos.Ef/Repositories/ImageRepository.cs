using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class ImageRepository :  IImageRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public ImageRepository(IMapper mapper, HSDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<ImageDto>> GetBy(int orderId)
            => _mapper.Map<List<ImageDto>>(await _context.Images
                .AsNoTracking()
                .Where(x => x.OrderId == orderId)
                .ToListAsync());
        public async Task Create(ImageDto entity)
        {
            var record = _mapper.Map<Image>(entity);
            await _context.Images.AddAsync(record);
            await _context.SaveChangesAsync();
        }
        public async Task Update(ImageDto entity)
        {
            var record = await _mapper.ProjectTo<ImageDto>(_context.Set<ImageDto>())
                 .Where(x => x.Id == entity.Id)
                 .FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
    }
}
