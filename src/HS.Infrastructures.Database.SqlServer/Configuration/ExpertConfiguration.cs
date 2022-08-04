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
                   .HasForeignKey(x => x.ExpertId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Suggestion)
                .WithOne(x => x.Expert)
                .HasForeignKey(x => x.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ApplicationUser).WithOne(x => x.Expert);

            builder.HasMany(d => d.HomeServices)
                .WithMany(p => p.Experts)

                .UsingEntity<Dictionary<string, object>>(
                    "ExpertHomeService",
                    l => l.HasOne<HomeService>().WithMany().HasForeignKey("HomeServicesId"),
                    r => r.HasOne<Expert>().WithMany().HasForeignKey("ExpertsId"),
                    j =>
                    {
                        j.HasKey("ExpertsId", "HomeServicesId");

                        j.ToTable("ExpertHomeService");

                        j.HasIndex(new[] { "HomeServicesId" }, "IX_ExpertHomeService_HomeServicesId");
                    });


        }
    }
}