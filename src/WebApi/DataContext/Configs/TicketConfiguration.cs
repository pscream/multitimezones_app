using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {


        public void Configure(EntityTypeBuilder<Ticket> builder)
        {

            builder.ToTable("Tickets");
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Project)
                .WithMany().HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);;
            builder.Property(e => e.Code).HasColumnType("nvarchar(50)");
            builder.Property(e => e.TransactionDate).HasColumnType("date");
            builder.Property(e => e.ReceivedOn).HasColumnType("datetimeoffset(3)");
            builder.Property(e => e.ReceivedOnUtc).HasColumnType("datetime2(3)");
            builder.Property(e => e.UpdatedOn).HasColumnType("datetimeoffset(3)");
            builder.Property(e => e.UpdatedOnUtc).HasColumnType("datetime2(3)");
            builder.HasOne(e => e.UpdatedBy)
                .WithMany().HasForeignKey(e => e.UpdatedById)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }

}