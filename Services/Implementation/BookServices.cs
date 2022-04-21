using BookApi.Entities;
using BookApi.Models.RequestModel;
using BookApi.Models.ResponseModel;
using BookApi.Repository;

namespace BookApi.Services.Implementation
{
    public class BookServices : IBookServices
    {
        private readonly IUnitofWork _unitOfWork;

        public BookServices(IUnitofWork unitofWork)
        {
            _unitOfWork = unitofWork;
        }

        public async Task<BookResponseModel> AddBookAsync(BookRequestModel model)
        {
            try
            {
                var book = new Book
                {
                    BookId = Guid.NewGuid(),
                    BookPrice = model.BookPrice,
                    BookTitle = model.BookTitle,
                    AuthorName = model.AuthorName
                };
                _unitOfWork.BookRepository.Insert(book);
                await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
                return new BookResponseModel
                {
                    BookId = book.BookId,
                    BookPrice = book.BookPrice,
                    BookTitle = book.BookTitle,
                    AuthorName = book.AuthorName
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
                // TODO
            }
        }

        public Task<BookResponseModel> CreateBookAsync(BookResponseModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IList<BookResponseModel>> GetBookAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookAsync(BookRequestModel model, Guid BookId)
        {
            try
            {
                var data = _unitOfWork.BookRepository.GetBook(BookId);
                if (data != null)
                {
                    var book = new Book
                    {
                        BookId = Guid.NewGuid(),
                        BookPrice = model.BookPrice,
                        BookTitle = model.BookTitle,
                        AuthorName = model.AuthorName
                    };
                    _unitOfWork.BookRepository.Update(data);
                     _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteBookAsync(Guid BookId)
        {
            try
            {
                var data = _unitOfWork.BookRepository.GetBook(BookId);
                if (data != null)
                {
                    _unitOfWork.BookRepository.Delete(data);
                    await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                // TODO
            }
        }
    }
}
