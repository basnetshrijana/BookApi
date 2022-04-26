using BookApi.Models.RequestModel;
using BookApi.Models.ResponseModel;

namespace BookApi.Services.Implementation
{
    public interface IBookServices
    {
        Task<BookResponseModel> AddBookAsync(BookRequestModel model);
        Task<IList<BookResponseModel>> GetBookAsync();
        Task<BookResponseModel> UpdateBookAsync(BookRequestModel model, Guid BookId);
        Task DeleteBookAsync(Guid BookId);
        Task<BookResponseModel> GetBook(Guid bookId);

    }
}