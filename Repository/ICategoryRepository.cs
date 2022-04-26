using BookApi.Entities;

namespace BookApi.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
         Task<Category> GetCategory(Guid id);
    }
}