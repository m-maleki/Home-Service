using HS.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HS.Infrastructures.Database.SqlServer.Configuration
{
    public class SpecialtyCategoryConfiguration : IEntityTypeConfiguration<SpecialtyCategory>
    {
        public void Configure(EntityTypeBuilder<SpecialtyCategory> builder)
        {
            builder.ToTable("SpecialtyCategories");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Specialties)
                .WithOne(x => x.SpecialtyCategory);
        }
    }
}
