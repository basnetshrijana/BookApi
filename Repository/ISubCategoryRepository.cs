using BookApi.Entities;

namespace BookApi.Repository
{
    public interface ISubCategoryRepository : IRepository<SubCategory>
    {
         Task<SubCategory> GetSubCategory(Guid id);
    }
}