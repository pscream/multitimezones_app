using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models;

namespace WebApi.DataContext.Configs
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {


        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("Users");
            builder.Property(e => e.UserName).HasColumnType("nvarchar(50)");

            builder.HasData(
                    new User()
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000001"),
                        UserName = "john.doe@abc.com",
                        IsActive = true,
                    },
                    new User()
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000002"),
                        UserName = "matt.matthews@abc.com",
                        IsActive = true,
                    },
                    new User()
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000003"),
                        UserName = "jane.jonson@abc.com",
                        IsActive = true,
                    }
            );

        }

    }

}