namespace BookApi.Controllers
{
    using BookApi.Entities;
    using BookApi.Models.RequestModel;
    using BookApi.Models.ResponseModel;
    using BookApi.Repository;
    using BookApi.Services.Implementation;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;

    public class BookController : BaseApiController
    {
        private readonly IBookServices _bookService;

        private readonly IValidator<BookRequestModel> _bookValidator;

        public BookController(
            IBookServices bookServices,
            IValidator<BookRequestModel> bookValidator
        )
        {
            _bookService = bookServices;
            _bookValidator = bookValidator;
        }

        [HttpPost]
        public async Task<BookResponseModel> Add(BookRequestModel model)
        {
            await _bookValidator
                .ValidateAsync(model, options => options.ThrowOnFailures())
                .ConfigureAwait(false);
            var response = await _bookService.AddBookAsync(model).ConfigureAwait(false);
            return response;
        }

        [HttpGet]
        public async Task<IList<BookResponseModel>> Get()
        {
            var response = await _bookService.GetBookAsync().ConfigureAwait(false);
            return response;
        }

        [HttpGet("{id}")]
        public async Task<BookResponseModel> GetBookAsync(Guid id)
        {
            var response = await _bookService.GetBook(id).ConfigureAwait(false);
            return response;
        }

        [HttpPut("{id}")]
        public async Task<BookResponseModel> UpdateBookAsync(BookRequestModel model, Guid id)
        {
            await _bookValidator
                .ValidateAsync(model, options => options.ThrowOnFailures())
                .ConfigureAwait(false);
            var response = await _bookService.UpdateBookAsync(model, id).ConfigureAwait(false);
            return response;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            await _bookService.DeleteBookAsync(id);
            return Ok();
        }
    }
}
