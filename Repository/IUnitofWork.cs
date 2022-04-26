namespace BookApi.Repository
{
    public interface IUnitofWork : IDisposable
    {
        Task<int> SaveChangesAsync();

        int SaveChanges();
        
        IBookRepository BookRepository { get; }
        IProductRepository ProductRepository{get;}
    }
}
