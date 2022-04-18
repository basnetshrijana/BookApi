using BookApi.Models.ResponseModel;

namespace BookApi.Services.Implementation
{
    public class BookServices : IBookServices
    {
        public Task<BookResponseModel> AddBookAsync(BookResponseModel model, Guid BookId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<BookResponseModel>> GetBookAsync(Guid BookId, string BookTitle, string BookAuthor)
        {
            throw new NotImplementedException();
        }
    }
}