using HS.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HS.Infrastructures.Database.Repos.Ef.Configuration
{
    public class HomeServiceConfiguration : IEntityTypeConfiguration<HomeService>
    {
        public void Configure(EntityTypeBuilder<HomeService> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("HomeServices");
            builder.HasOne(x => x.Orders)
                .WithOne(x => x.HomeService);
        }
    }
}
