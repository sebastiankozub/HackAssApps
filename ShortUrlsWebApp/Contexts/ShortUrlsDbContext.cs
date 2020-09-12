﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShortUrlsWebApp.Models;

namespace ShortUrlsWebApp.Contexts
{
    public class ShortUrlsDbContext : DbContext
    {
        public ShortUrlsDbContext(DbContextOptions options) : base(options)
        {



        }

        public DbSet<Url> Urls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // model builder is for constant data like read-only lookups used in the business 
            // e.g. cm, inch, m, feet and their muliplayers 
            // Those used only to Debug during Development should be in DbInitialization
            // But let it be ;-)
            modelBuilder.Entity<Url>().HasData(
                new Url
                {
                    UrlId = 1,
                    GivenUrl = "https://docs.microsoft.com/en-gb/ef/core/modeling/data-seeding",
                    ShortUrl = "/sdsf34ds6f5dm",
                    Created = new DateTime(1979, 04, 25)
                },
                new Url
                {
                    UrlId = 2,
                    GivenUrl = "https://docs.microsoft.com/en-gb/dotnet/csharp/tutorials/working-with-linq",
                    ShortUrl = "/sdsf34d66fsd",
                    Created = new DateTime(1981, 07, 13)
                },
                new Url
                {
                    UrlId = 3,
                    GivenUrl = "https://docs.microsoft.com/en-gb/dotnet/csharp/",
                    ShortUrl = "/sdgdgffd66fsd",
                    Created = new DateTime(1981, 07, 13)
                }
            );

            modelBuilder.Entity<Url>()
                .HasIndex(b => b.ShortUrl)
                .IsUnique()
                .HasDatabaseName("Index_Url")
                .IncludeProperties(b => new { b.GivenUrl });
        }
    }
}
