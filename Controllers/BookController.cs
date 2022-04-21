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

        public BookController(IBookServices bookServices, IValidator<BookRequestModel> bookValidator)
        {
            _bookService = bookServices;
            _bookValidator = bookValidator;
        }

        [HttpPost]
        public async Task<BookResponseModel> Add(BookRequestModel model)
        {
            await _bookValidator.ValidateAsync(model,options => options.ThrowOnFailures()).ConfigureAwait(false);
           var response = await _bookService.AddBookAsync(model).ConfigureAwait(false);
           return response;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get()
        {
            
            await _bookService.GetBookAsync().ConfigureAwait(false);
            return Ok();

        }

        [HttpPut("{BookId}")]

        public async Task<IActionResult> UpdateBook(Guid BookId, BookRequestModel model)
        {
             await _bookValidator.ValidateAsync(model,options => options.ThrowOnFailures()).ConfigureAwait(false);
           await _bookService.UpdateBookAsync(model).ConfigureAwait(false);
           return Ok();

        }


        [HttpDelete("{BookId}")]

        public async Task<IActionResult> DeleteBook(Guid BookId)
        {
            await _bookService.DeleteBookAsync(BookId);
            return Ok();
        }

        


    }
}
