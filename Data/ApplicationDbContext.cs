 using Microsoft.EntityFrameworkCore;
 using BookApi.Entities;


namespace BookApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
        public DbSet<Book> Books{get;set;}
        
    }
}