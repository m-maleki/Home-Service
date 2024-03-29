﻿using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class ImageRepository :  IImageRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;
        private readonly ILogger<ImageRepository> _loger;

        public ImageRepository(IMapper mapper, HSDbContext context, ILogger<ImageRepository> loger)
        {
            _mapper = mapper;
            _context = context;
            _loger = loger;
        }
        public async Task<List<ImageDto>> GetBy(int orderId, CancellationToken cancellationToken)
            => _mapper.Map<List<ImageDto>>(await _context.Images
                .AsNoTracking()
                .Where(x => x.OrderId == orderId)
                .ToListAsync(cancellationToken));
        public async Task Create(ImageDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Image>(entity);
            try
            {
                await _context.Images.AddAsync(record);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch(Exception ex)
            {
                _loger.LogError("Error in add new image {exception}", ex);
            }

        }
        public async Task Update(ImageDto entity, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<ImageDto>(_context.Set<ImageDto>())
                 .Where(x => x.Id == entity.Id)
                 .FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
