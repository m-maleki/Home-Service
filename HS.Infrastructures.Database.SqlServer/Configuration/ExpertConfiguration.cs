using HS.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HS.Infrastructures.Database.SqlServer.Configuration
{
    public class ExpertConfiguration : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Experts");

            builder.HasMany(x => x.Comments)
                   .WithOne(x => x.Expert)
                   .HasForeignKey(x => x.ExpertId);

            builder.HasMany(x => x.Suggestion)
                .WithOne(x => x.Expert)
                .HasForeignKey(x => x.ExpertId);

            builder.HasOne(x => x.ApplicationUser).WithOne(x => x.Expert);

        }
    }
}