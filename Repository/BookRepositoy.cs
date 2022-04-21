using System.Linq.Expressions;
using BookApi.Data;
using BookApi.Entities;
using BookApi.Models.RequestModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;

namespace BookApi.Repository
{
    public class BookRepository: Repository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Guid BookId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Book>> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetBook(Guid BookId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(BookRequestModel model, Guid BookId)
        {
            throw new NotImplementedException();
        }
    }
}