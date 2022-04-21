using BookApi.Entities;
using BookApi.Models.RequestModel;

namespace BookApi.Repository
{
    public interface IBookRepository : IRepository<Book> {
       
       Task<IList<Book>> GetAllBooks();
       public Book GetBook(Guid BookId);

       public void CreateBook(Book book);
       
       public void UpdateBook(BookRequestModel model,Guid BookId);

       public void DeleteBook(Guid BookId);
     }
}
