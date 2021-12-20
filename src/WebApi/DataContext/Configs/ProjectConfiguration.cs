using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {


        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.ToTable("Projects");
            builder.Property(e => e.Code).HasColumnType("nvarchar(50)");
            builder.Property(e => e.CreatedDate).HasColumnType("date");
            builder.Property(e => e.UpdatedOn).HasColumnType("datetimeoffset(3)");
            builder.Property(e => e.UpdatedOnUtc).HasColumnType("datetime2(3)");
            builder.HasOne(e => e.UpdatedBy).WithMany().HasForeignKey(e => e.UpdatedById);

        }

    }

}