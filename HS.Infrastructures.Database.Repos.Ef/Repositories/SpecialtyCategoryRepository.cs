using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class SpecialtyCategoryRepository : ISpecialtyCategoryRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public SpecialtyCategoryRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SpecialtyCategoryDto>> GetAll()
            => _mapper.Map<List<SpecialtyCategoryDto>>(await _context.SpecialtyCategories.ToListAsync());

        public async Task<SpecialtyCategoryDto> GetBy(int id)
            => await _mapper.ProjectTo<SpecialtyCategoryDto>(_context.SpecialtyCategories)
            .Where(x => x.Id == id).SingleOrDefaultAsync();

        public async Task<SpecialtyCategoryDto> GetBy(string name)
           => await _mapper.ProjectTo<SpecialtyCategoryDto>(_context.SpecialtyCategories)
        .Where(x => x.Name == name).SingleOrDefaultAsync();

        public async Task Create(SpecialtyCategoryDto entity)
        {
            var record = _mapper.Map<SpecialtyCategory>(entity);
            await _context.SpecialtyCategories.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task Update(SpecialtyCategoryDto entity)
        {
            var record = await _mapper.ProjectTo<SpecialtyCategoryDto>(_context.Set<SpecialtyCategoryDto>())
                 .Where(x => x.Id == entity.Id).SingleOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
    }
}
