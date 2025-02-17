using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModelsUpgrade.Apstractions;
using Repositories.Interfaces;
using System.Linq.Expressions;

namespace Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : Entity, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly ILogger<Repository<T>> _logger;

        public Repository(DbContext context, ILogger<Repository<T>> logger)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _logger = logger;
        }

        #region Private Helper Methods

        /// <summary>
        /// Handles database operations and provides error handling.
        /// </summary>
        private async Task<bool> ExecuteDbOperationAsync(Func<Task> operation)
        {
            try
            {
                await operation();
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Handles fetching data and error handling.
        /// </summary>
        private async Task<T?> FetchSingleAsync(Func<Task<T?>> fetchOperation)
        {
            try
            {
                return await fetchOperation();
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, ex.Message);
                return null;
            }
        }

        #endregion

        #region Create

        public async Task<bool> InsertAsync(T entity, CancellationToken cancellationToken = default)
        {
            return await ExecuteDbOperationAsync(async () => await _dbSet.AddAsync(entity, cancellationToken));
        }

        public async Task<Guid> InsertAndReturnIdAsync(T entity, CancellationToken cancellationToken = default)
        {
            if (await InsertAsync(entity, cancellationToken))
            {

                return (await _dbSet.LastAsync()).Id;

            }
            return Guid.Empty;
        }

        public async Task<bool> BulkInsertAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return await ExecuteDbOperationAsync(async () => await _dbSet.AddRangeAsync(entities, cancellationToken));
        }

        #endregion

        #region Read

        public async Task<T?> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await FetchSingleAsync(async () => await _dbSet.FindAsync(new { id }, cancellationToken));
        }

        public async Task<T?> GetAsync(Guid id, Guid companyDataId, CancellationToken cancellationToken = default)
        {
            return await FetchSingleAsync(async () => await _dbSet.FindAsync(new { id, companyDataId }, cancellationToken));
        }

        public async Task<T?> GetAsync(Func<T, bool> filter, CancellationToken cancellationToken = default)
        {
            return await FetchSingleAsync(async () => await Task.Run(() => _dbSet.AsQueryable().FirstOrDefault(filter), cancellationToken));
        }

        public async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
        {
            return await FetchSingleAsync(async () => await _dbSet.FirstOrDefaultAsync(filter, cancellationToken));
        }

        public async Task<T?> GetLastOrDefaultAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
        {
            return await FetchSingleAsync(async () => await _dbSet.LastOrDefaultAsync(filter, cancellationToken));
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
        {
            return await _dbSet.CountAsync(filter, cancellationToken);
        }

        public async Task<IQueryable<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(_dbSet.AsQueryable());
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default, params string[] includeProperties)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null) query = query.Where(filter);
            foreach (var include in includeProperties) query = query.Include(include);
            if (orderBy != null) query = orderBy(query);

            return await Task.FromResult(query);
        }
        //has an error because the async not support the out or ref can instead use PageResult object 
        public async Task<IQueryable<T>> GetPagedAsync(int pageSize, int currentPage, out int totalCount, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _dbSet;

            totalCount = await query.CountAsync(cancellationToken);

            if (orderBy != null) query = orderBy(query);

            return query.Skip((currentPage - 1) * pageSize).Take(pageSize);
        }

        public async Task<IQueryable<T>> GetFilteredAsync(int pageSize, int currentPage, out int totalCount, Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default, params string[] includeProperties)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
                query = query.Where(filter);

            foreach (var include in includeProperties)
                query = query.Include(include);

            totalCount = await query.CountAsync(cancellationToken);

            if (orderBy != null)
                query = orderBy(query);

            return query.Skip((currentPage - 1) * pageSize).Take(pageSize);
        }

        #endregion

        #region Update

        public async Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            return await ExecuteDbOperationAsync(() => Task.Run(() => _dbSet.Update(entity), cancellationToken));
        }

        public async Task<bool> UpdateWithConcurrencyAsync(T entity, CancellationToken cancellationToken = default)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                _dbSet.Entry(entity).State = EntityState.Modified;
                var result = await _context.SaveChangesAsync(cancellationToken);
                if (result > 0)
                {
                    await transaction.CommitAsync(cancellationToken);
                    return true;
                }
                await transaction.RollbackAsync(cancellationToken);
                return false;


            }
            catch (DbUpdateConcurrencyException ex)
            {
                await transaction.RollbackAsync(cancellationToken);
                _logger.LogError(ex, ex.Message);
                return false;
            }
        }

        public async Task<bool> BulkUpdateAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return await ExecuteDbOperationAsync(() => Task.Run(() => _dbSet.UpdateRange(entities), cancellationToken));
        }

        #endregion

        #region Delete

        public async Task<bool> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            return await ExecuteDbOperationAsync(() => Task.Run(() => _dbSet.Remove(entity), cancellationToken));
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var entity = await _dbSet.FindAsync(new[] { id }, cancellationToken);
            return entity != null && await DeleteAsync(entity, cancellationToken);
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
        {
            var entities = await _dbSet.Where(filter).ToListAsync(cancellationToken);
            return entities.Any() && await BulkDeleteAsync(entities, cancellationToken);
        }

        public async Task<bool> BulkDeleteAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return await ExecuteDbOperationAsync(() => Task.Run(() => _dbSet.RemoveRange(entities), cancellationToken));
        }

        #endregion
    }
}
