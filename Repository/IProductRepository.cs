using BookApi.Entities;
namespace BookApi.Repository
{
    public interface IProductRepository: IRepository<Product>
    {
         Task<Product> GetProduct(Guid id);
    }
}