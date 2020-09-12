using Microsoft.EntityFrameworkCore;
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
    }
}
