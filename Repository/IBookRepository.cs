using BookApi.Entities;
using BookApi.Models.RequestModel;

namespace BookApi.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> GetBook(Guid Id);
    }
}
