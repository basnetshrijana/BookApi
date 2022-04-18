using System.Linq.Expressions;
using BookApi.Data;
using BookApi.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;

namespace BookApi.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<BookRepository> _logger;

    
         public  Task<IList<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Book>> GetAllAsync(Expression<Func<Book, bool>> predicate = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, Func<IQueryable<Book>, IIncludableQueryable<Book, object>> include = null, bool disableTracking = true, bool ignoreQueryFilters = false)
        {
            throw new NotImplementedException();
        }

        public Book Insert(Book entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask<EntityEntry<Book>> InsertAsync(Book entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<Book> entities)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(IEnumerable<Book> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Book> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Book> entities)
        {
            throw new NotImplementedException();
        }
    }

    public class GenericRepository<T>
    {
    }
}