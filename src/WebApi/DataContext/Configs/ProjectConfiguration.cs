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
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Code).HasColumnType("nvarchar(50)");
            builder.Property(e => e.StartDate).HasColumnType("date");
            builder.Property(e => e.EndDate).HasColumnType("date");
            builder.Property(e => e.CreatedDate).HasColumnType("date");
            builder.Property(e => e.UpdatedOn).HasColumnType("datetimeoffset(3)");
            builder.Property(e => e.UpdatedOnUtc).HasColumnType("datetime2(3)");
            builder.HasOne(e => e.UpdatedBy)
                .WithMany().HasForeignKey(e => e.UpdatedById)
                .OnDelete(DeleteBehavior.NoAction);

            var localNowOffset = new DateTimeOffset(DateTime.Now, TimeSpan.FromHours(2)); 

            builder.HasData(
                new Project()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "PRJ001",
                    StartDate = new DateTime(2021, 12, 31),
                    EndDate = new DateTime(2022, 05, 01),
                    CreatedDate = localNowOffset.Date.Date,
                    UpdatedOn = localNowOffset,
                    UpdatedOnUtc = localNowOffset.UtcDateTime,
                    UpdatedById = new Guid("00000000-0000-0000-0000-000000000001"),
                    IsActive = true,
                }
            );

        }

    }

}