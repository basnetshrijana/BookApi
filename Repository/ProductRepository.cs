using BookApi.Data;
using BookApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Repository
{
    public class ProductRepository : Repository<Entities.Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Product> GetProduct(Guid id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(x=> x.ProductId==id).ConfigureAwait(false);
        }
    }
}