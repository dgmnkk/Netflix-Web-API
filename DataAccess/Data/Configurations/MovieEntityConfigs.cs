using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Entities;

namespace DataAccess.Data.Configurations
{
    public class MovieEntityConfigs : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Movies");

            builder.HasOne(x => x.Genre).WithMany(x => x.Movies).HasForeignKey(x => x.GenreId);
        }
    }
}
