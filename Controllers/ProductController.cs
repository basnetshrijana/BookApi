using BookApi.Models.RequestModel;
using BookApi.Models.ResponseModel;
using BookApi.Services.Implementation;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    public class ProductController : BaseApiController
    {
        private readonly IProductServices _productService;
        private readonly IValidator<ProductRequestModel> _productValidator;
        public ProductController(IProductServices productServices, IValidator<ProductRequestModel> productValidator)
        {
            _productService=productServices;
            _productValidator=productValidator;
        }
        [HttpPost]

        public async Task<ProductResponseModel> Add(ProductRequestModel model)
        {
            await _productValidator.ValidateAsync(model,options=> options.ThrowOnFailures()).ConfigureAwait(false);
            var response= await _productService.AddProductAsync(model).ConfigureAwait(false);
            return response;
            
        }

        [HttpGet]

        public async Task<IList<ProductResponseModel>> Get()
        {
            var response=await _productService.GetProductAsync().ConfigureAwait(false);
            return response;
        } 

        [HttpGet("{id}")]
        public async Task<ProductResponseModel> UpdateProductAsync(Guid id)
        {
            var response=await _productService.GetProduct(id).ConfigureAwait(false);
            return response;
        }
          [HttpPut("{id}")]
        public async Task<ProductResponseModel> UpdateProductAsync(ProductRequestModel model, Guid id)
        {
            await _productValidator
                .ValidateAsync(model, options => options.ThrowOnFailures())
                .ConfigureAwait(false);
            var response = await _productService.UpdateProductAsync(model, id).ConfigureAwait(false);
            return response;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok();
        }
    }
}