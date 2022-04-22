using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;

namespace BookApi.Repository
{
    public interface IRepository <TEntity> where TEntity:class
    {
        Task<IList<TEntity>> GetAllAsync();

       

        TEntity Insert(TEntity entity);

        ValueTask<EntityEntry<TEntity>> InsertAsync(TEntity entity);

        void Insert(IEnumerable<TEntity> entities);

        Task InsertAsync(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Update(IEnumerable<TEntity> entities);
         ValueTask<EntityEntry<TEntity>> UpdateAsync(TEntity entity);

        void Delete(TEntity entity);

        void Delete(IEnumerable<TEntity> entities);
         
    }
}