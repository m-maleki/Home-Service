using HS.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HS.Infrastructures.Database.SqlServer.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Comments");
            builder.HasOne(x => x.Expert)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
