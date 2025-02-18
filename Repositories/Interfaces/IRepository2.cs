using ModelsUpgrade.Apstractions;
using Repositories.Result;
using System.Linq.Expressions;

namespace Repositories.Interfaces
{
    public interface IRepository2<T> where T : Entity, new()
    {
        #region Create

        Task<bool> InsertAsync(T entity, CancellationToken cancellationToken = default);

        Task<Guid> InsertAndReturnIdAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> BulkInsertAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        #endregion

        #region Read
        Task<T?> GetAsync(Guid id, CancellationToken cancellationToken = default);

        Task<T?> GetAsync(Guid id, Guid companyDataId, CancellationToken cancellationToken = default);

        Task<T?> GetAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default);

        Task<T?> GetAsync(Guid id = default, Guid companyDataId = default, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includes);

        Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default);

        Task<T?> GetLastOrDefaultAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default);

        Task<int> GetCountAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default);

        Task<IQueryable<T>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default, params Expression<Func<T, object>>[] includes);

        Task<PageResult<T>> GetPagedAsync(int pageSize, int currentPage, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default);

        Task<PageResult<T>> GetFilteredAsync(int pageSize, int currentPage, Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default, params Expression<Func<T, object>>[] includes);
        #endregion

        #region Update

        Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> UpdateWithConcurrencyAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> BulkUpdateAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        #endregion

        #region Delete

        Task<bool> DeleteAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);

        Task<bool> DeleteAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default);

        Task<bool> BulkDeleteAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        #endregion
    }
}
