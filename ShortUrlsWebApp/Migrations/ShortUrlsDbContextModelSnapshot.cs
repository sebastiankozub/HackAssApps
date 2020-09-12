﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShortUrlsWebApp.Contexts;

namespace ShortUrlsWebApp.Migrations
{
    [DbContext(typeof(ShortUrlsDbContext))]
    partial class ShortUrlsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.8.20407.4");

            modelBuilder.Entity("ShortUrlsWebApp.Models.Url", b =>
                {
                    b.Property<long>("UrlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("GivenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrlId");

                    b.ToTable("Url");

                    b.HasData(
                        new
                        {
                            UrlId = 1L,
                            Created = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GivenUrl = "https://docs.microsoft.com/en-gb/ef/core/modeling/data-seeding",
                            ShortUrl = "/sdsf34ds6f5dm"
                        },
                        new
                        {
                            UrlId = 2L,
                            Created = new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GivenUrl = "https://docs.microsoft.com/en-gb/dotnet/csharp/tutorials/working-with-linq",
                            ShortUrl = "/sdsf34d66fsd"
                        },
                        new
                        {
                            UrlId = 3L,
                            Created = new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GivenUrl = "https://docs.microsoft.com/en-gb/dotnet/csharp/",
                            ShortUrl = "/sdgdgffd66fsd"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
