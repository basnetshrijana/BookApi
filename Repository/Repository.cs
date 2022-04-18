// using System.Linq;
// using System.Linq.Expressions;
// using BookApi.Data;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.ChangeTracking;
// using Microsoft.EntityFrameworkCore.Query;

// namespace BookApi.Repository
// {
//     public class Repository<TEntity> :IRepository<TEntity> where TEntity : class
//     {
//             protected readonly ApplicationDbContext _dbContext;

//             protected readonly DbSet<TEntity> _dbSet;

//             public Repository(ApplicationDbContext dbContext)
//             {
//                 _dbContext=dbContext ?? throw new ArgumentException(nameof(dbContext));
//                 _dbSet=_dbContext.Set<TEntity>();
//             }
//             public async Task<IList<TEntity>> GetAllAsync()
//             {
//                 return await _dbSet.ToListAsync();
//             }

//             public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate=null,
//                     Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> orderBy=null,
//                     Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include=null,
//                     bool disableTracking=true, bool ignoreQueryFilters=false)
//                     {
//                         IQueryable<TEntity> query=_dbSet;
//                         if(disableTracking)
//                         {
//                             query=query.AsNoTracking();

//                         }
//                         if(include!=null)
//                         {
//                             query=include(query);
//                         }
//                         if(predicate!=null)
//                         {
//                             query=query.Where(predicate);
//                         }
//                         if(ignoreQueryFilters)
//                         {
//                             query=query.IgnoreQueryFilters();
//                         }
//                         if(orderBy!=null)
//                         {
//                             return await orderBy(query).ToListAsync();
//                         }
//                         else
//                         {
//                             return await query.ToListAsync();
//                         }

//                     }
//                     public virtual ValueTask<EntityEntry<TEntity>> InsertAsync(TEntity entity, CancellationToken cancellationToken=default)
//                     {
//                         return  _dbSet.AddAsync(entity, cancellationToken);
//                     }
//                  //   public virtual Task Insert(IEnumerable<TEntity> entities) => _dbSet.AddRange(entities);

//                     public  virtual Task InsertAsync(IEnumerable<TEntity>entities, CancellationToken cancellationToken= default(CancellationToken))=> _dbSet.AddRangeAsync(entities, cancellationToken);

//                     public virtual void Update(TEntity entity)
//                     {
//                         _dbSet.Update(entity);
//                     }
//                     public virtual void Update(IEnumerable<TEntity> enti)=>_dbSet.UpdateRange(entities);

//         public TEntity Insert(TEntity entity)
//         {
//             throw new NotImplementedException();
//         }

//         void IRepository<TEntity>.Insert(IEnumerable<TEntity> entities)
//         {
//             throw new NotImplementedException();
//         }

//         public void Delete(TEntity entity)
//         {
//             throw new NotImplementedException();
//         }

//         public void Delete(IEnumerable<TEntity> entities)
//         {
//             throw new NotImplementedException();
//         }
//     }
//     }
