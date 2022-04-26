using BookApi.Data;
using BookApi.Entities;

namespace BookApi.Repository
{
    public class UnitofWork : IUnitofWork
    {
         private bool disposed=false;

         private readonly ApplicationDbContext _context;

         public IRepository<Book> _bookRepository;

         public IBookRepository BookRepository{get;}

        public IRepository<Product> _productRepository;
        public IProductRepository ProductRepository{get;}

        public UnitofWork(ApplicationDbContext context, IBookRepository bookRepository,IProductRepository productRepository)
         {
             _context=context ?? throw new ArgumentNullException(nameof(context));
             BookRepository=bookRepository;
             ProductRepository=productRepository;
         }
         public void Dispose()
         {
             Dispose(true);
             GC.SuppressFinalize(this);

         }
         public int SaveChanges()
        {
            return _context.SaveChanges();

        }
        public async Task<int> SaveChange()
        {
            return await _context.SaveChangesAsync();
        }


        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed=true;
        }

        public async Task<int> SaveChangesAsync()
        {
          return await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}