using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace DataAccess.Data.Configurations
{
    public class MovieSelectionConfigs : IEntityTypeConfiguration<MovieSelection>
    {
        public void Configure(EntityTypeBuilder<MovieSelection> builder)
        {
            builder
             .HasKey(ms => new { ms.MovieId, ms.SelectionId });
            builder.HasOne( x=> x.Movie).WithMany(x => x.MovieSelection ).HasForeignKey(x=>x.MovieId);
            builder.HasOne(x => x.Selection).WithMany(x => x.MovieSelection).HasForeignKey(x=>x.SelectionId);
        }
    }
}
