using HS.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Infrastructures.Database.SqlServer.Configuration
{
    public class HomeServiceCategoryConfiguration : IEntityTypeConfiguration<HomeServiceCategory>
    {
        public void Configure(EntityTypeBuilder<HomeServiceCategory> builder)
        {
            builder.ToTable("HomeServiceCategories");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.HomeServices)
                .WithOne(x => x.HomeServiceCategory);
        }
    }
}
