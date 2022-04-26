using System.Linq.Expressions;
using BookApi.Data;
using BookApi.Entities;
using BookApi.Models.RequestModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;

namespace BookApi.Repository
{
    public class BookRepository: Repository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _context=dbContext;
        }

        public async Task<Book> GetBook(Guid Id)
        {
           return await _context.Books.FirstOrDefaultAsync(x => x.BookId == Id).ConfigureAwait(false);
        }
    }
}