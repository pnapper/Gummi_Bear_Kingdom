using System;
using Microsoft.EntityFrameworkCore;

namespace Gummi_Bear_Kingdom.Models
{
    public class GummiBearDbContext : DbContext
    {
        public GummiBearDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=Gummi_Bear_Kingdom;uid=root;pwd=root;");
        }

        public GummiBearDbContext(DbContextOptions<GummiBearDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
