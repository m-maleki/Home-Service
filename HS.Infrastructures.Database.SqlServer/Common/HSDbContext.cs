using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.Repos.Ef.Configuration;
using HS.Infrastructures.Database.SqlServer.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.SqlServer.Common
{
    public class AppUser : IdentityUser<int>
    {

    }

    public class HSDbContext :IdentityDbContext<ApplicationUser, IdentityRole<Guid>,Guid>
    {

        public HSDbContext(DbContextOptions<HSDbContext> options) : base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>(b =>
            {
                b.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
            });

            builder.Entity<IdentityRole<Guid>>(b =>
            {
                b.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
            });
            
            builder.ApplyConfiguration(new HomeServiceCategoryConfiguration());
            builder.ApplyConfiguration(new HomeServiceConfiguration());
            builder.ApplyConfiguration(new SuggestionConfiguration());
            builder.ApplyConfiguration(new SpecialtyConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new ExpertConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new ImageConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new SpecialtyCategoryConfiguration());
            base.OnModelCreating(builder);

        }

        public DbSet<HomeServiceCategory> HomeServiceCategories { get; set; } = null!;
        public DbSet<HomeService> HomeServices { get; set; } = null!;
        public DbSet<Suggestion> Suggestions { get; set; } = null!;
        public DbSet<Specialty> Specialties { get; set; } = null!;
        public DbSet<SpecialtyCategory> SpecialtyCategories { get; set; } = null!;
    
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public  DbSet<Expert> Experts { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Image> Images { get; set; } = null!;

    }
}