using System.Linq.Expressions;

namespace BookApi.Repository
{
    public interface IRepository <TEntity> where TEntity:class
    {
        Task<IList<TEntity>> GetAllAsync();

        Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate=null,
                        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy=null,
                        Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>> include=null,
                        bool disableTracking=true,
                        bool ignoreQueryFilters=false);

        TEntity Insert(TEntity entity);

        ValueTask<EntityEntry<TEntity>> InsertAsync(TEntity entity, CancellationToken cancellationToken=default(CancellationToken));

        void Insert(IEnumerable<TEntity> entities);

        Task InsertAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken=default(CancellationToken));

        void Update(TEntity entity);

        void Update(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        void Delete(IEnumerable<TEntity> entities);
         
    }
}