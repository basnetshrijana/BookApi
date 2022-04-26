using BookApi.Data;
using BookApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Repository
{
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public SubCategoryRepository(ApplicationDbContext dbContext):base (dbContext)
        {
            _context=dbContext;
            
        }
        public async Task<SubCategory> GetSubCategory(Guid id)
        {
            return await _context.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryId == id).ConfigureAwait(false);
        }
    }
}