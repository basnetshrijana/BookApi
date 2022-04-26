using BookApi.Entities;
using BookApi.Models.RequestModel;
using BookApi.Models.ResponseModel;
using BookApi.Repository;

namespace BookApi.Services.Implementation
{
    public class ProductServices : IProductServices
    {
        private readonly IUnitofWork _unitOfWork;
        public ProductServices(IUnitofWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
            
        }
        public async Task<ProductResponseModel> AddProductAsync(ProductRequestModel model)
        {
            try
            {
                var product=new Product
                {
                    ProductId=Guid.NewGuid(),
                    ProductName=model.ProductName,
                    ProductPrice=model.ProductPrice
                };
                _unitOfWork.ProductRepository.Insert(product);
                await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
                return new ProductResponseModel
                {

                    ProductId=product.ProductId,
                    ProductName=product.ProductName,
                    ProductPrice=product.ProductPrice
                };
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task DeleteProductAsync(Guid id)
        {
            try
            {
                var product=await _unitOfWork.ProductRepository.GetProduct(id);
                if(product!=null)
                {
                    _unitOfWork.ProductRepository.Delete(product);
                    await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<ProductResponseModel> GetProduct(Guid id)
        {
            try
            {
                var product=await _unitOfWork.ProductRepository.GetProduct(id);
                if(product==null)
                {
                    throw new Exception("Message not Found");
                }
                return new ProductResponseModel
                {
                    ProductId=product.ProductId,
                    ProductName=product.ProductName,
                    ProductPrice=product.ProductPrice

                };
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<IList<ProductResponseModel>> GetProductAsync()
        {
            try
            {
                var product=await _unitOfWork.ProductRepository.GetAllAsync().ConfigureAwait(false);
                var result=product.Select(
                    x => new ProductResponseModel
                    {
                        ProductId=x.ProductId,
                        ProductName=x.ProductName,
                        ProductPrice=x.ProductPrice
                    }).ToList();
                    return result;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<ProductResponseModel> UpdateProductAsync(ProductRequestModel model, Guid id)
        {
            try
            {
            var product=await _unitOfWork.ProductRepository.GetProduct(id).ConfigureAwait(false);
            if(product==null)
            {
                throw new Exception("Product not found.");
            }
        
           product.ProductName=model.ProductName;
           product.ProductPrice=model.ProductPrice;

           _unitOfWork.ProductRepository.Update(product);
           await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
           return new ProductResponseModel
           {
               ProductId=product.ProductId,
               ProductName=product.ProductName,
               ProductPrice=product.ProductPrice
           };
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}