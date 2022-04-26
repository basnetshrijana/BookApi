using Microsoft.EntityFrameworkCore;
using BookApi.Entities;
using BookApi.Entities.EntityConfiguration;

namespace BookApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }

        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductConfiguration());

            builder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
