using BookApi.Models.RequestModel;
using BookApi.Models.ResponseModel;

namespace BookApi.Services.Implementation
{
    public interface IBookServices
    {
        Task<BookResponseModel> AddBookAsync(BookRequestModel model);
        Task<IList<BookResponseModel>> GetBookAsync();

        Task<BookResponseModel> CreateBookAsync(BookResponseModel model);
        Task<BookResponseModel> UpdateBook(BookResponseModel model, Guid BookId);
        Task DeleteBookAsync(Guid BookId);
    }
}