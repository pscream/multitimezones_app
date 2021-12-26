﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.DataContext;

namespace WebApi.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Models.Database.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<Guid>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset(3)");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2(3)");

                    b.HasKey("Id");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Code = "PRJ001",
                            CreatedDate = new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            StartDate = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedById = new Guid("00000000-0000-0000-0000-000000000001"),
                            UpdatedOn = new DateTimeOffset(new DateTime(2021, 12, 26, 11, 26, 34, 249, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 2, 0, 0, 0)),
                            UpdatedOnUtc = new DateTime(2021, 12, 26, 9, 26, 34, 249, DateTimeKind.Utc).AddTicks(635)
                        });
                });

            modelBuilder.Entity("WebApi.Models.Database.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("ReceivedOn")
                        .HasColumnType("datetimeoffset(3)");

                    b.Property<DateTime?>("ReceivedOnUtc")
                        .HasColumnType("datetime2(3)");

                    b.Property<DateTime?>("TransactionDate")
                        .HasColumnType("date");

                    b.Property<Guid>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset(3)");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2(3)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("WebApi.Models.Database.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            IsActive = true,
                            UserName = "john.doe@abc.com"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            IsActive = true,
                            UserName = "matt.matthews@abc.com"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            IsActive = true,
                            UserName = "jane.jonson@abc.com"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Database.Project", b =>
                {
                    b.HasOne("WebApi.Models.Database.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Models.Database.Ticket", b =>
                {
                    b.HasOne("WebApi.Models.Database.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Database.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
