using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.SqlServer.Common
{
    public class AppUser : IdentityUser<int>
    {

    }

    public class HSDbContext :IdentityDbContext<IdentityUser<int>,IdentityRole<int>,int>
    {

        public HSDbContext(DbContextOptions<HSDbContext> options) : base(options)
        {
         
        }

        public  DbSet<Comment> Comments { get; set; } = null!;
        public  DbSet<Customer> Customers { get; set; } = null!;
        public  DbSet<Expert> Experts { get; set; } = null!;
        public  DbSet<HomeService> HomeServices { get; set; } = null!;
        public DbSet<HomeServiceCategory> HomeServiceCategories { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Specialty> Specialties { get; set; } = null!;
        public DbSet<Suggestion> Suggestions { get; set; } = null!;
        public DbSet<Image> Images { get; set; } = null!;

    }
}