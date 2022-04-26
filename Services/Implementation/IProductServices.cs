using BookApi.Models.RequestModel;
using BookApi.Models.ResponseModel;

namespace BookApi.Services.Implementation
{
    public interface IProductServices
    {
         Task<ProductResponseModel> AddProductAsync(ProductRequestModel model);
         Task<IList<ProductResponseModel>> GetProductAsync();
         Task<ProductResponseModel> UpdateProductAsync(ProductRequestModel model, Guid id);
         Task DeleteProductAsync(Guid id);
         Task<ProductResponseModel> GetProduct(Guid id);
    }
}