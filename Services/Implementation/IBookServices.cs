using BookApi.Models.ResponseModel;

namespace BookApi.Services.Implementation
{
    public interface IBookServices
    {
        Task<BookResponseModel> AddBookAsync(BookResponseModel model, Guid BookId);
        Task<IList<BookResponseModel>> GetBookAsync(Guid BookId,string BookTitle,string BookAuthor);
    }
}