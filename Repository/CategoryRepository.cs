using BookApi.Data;
using BookApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Repository
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext dbContext): base(dbContext)
        {
            _context=dbContext;
        }
        public  async Task<Category> GetCategory(Guid id)
        {
            return await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id).ConfigureAwait(false);
        }
    }
}