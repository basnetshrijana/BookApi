namespace BookApi.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<BookRepository> _logger;

        private readonly IMapper<>
    }
}