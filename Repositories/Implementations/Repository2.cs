using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Data;
using Repositories.Interfaces;
using Repositories.Result;
using System.Linq.Expressions;

namespace Repositories.Implementations
{
    public class Repository2<T> : IRepository2<T>
        where T : Entity, new()
    {
        #region Fields and Constructor

        private readonly ILogger<Repository2<T>> _logger;
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository2(ILogger<Repository2<T>> logger, ApplicationDbContext context)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        #endregion

        #region Private Helper Methods

        /// <summary>
        /// Saves changes to the database asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>True if changes were saved successfully; otherwise, false.</returns>
        private async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }

        /// <summary>
        /// Removes entities based on a predicate or a list of entities.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="predicate">The predicate to filter entities.</param>
        /// <param name="entities">The entities to remove.</param>
        /// <returns>True if entities were removed successfully; otherwise, false.</returns>
        private async Task<bool> RemoveAsync(CancellationToken cancellationToken = default, Expression<Func<T, bool>>? predicate = null, params T[] entities)
        {
            try
            {
                if (predicate == null && (entities == null || entities.Length == 0))
                {
                    _logger.LogWarning("RemoveAsync called with no parameters. No action taken.");
                    return false;
                }

                if (predicate != null)
                {
                    var query = _dbSet.Where(predicate);
                    if (await query.AnyAsync(cancellationToken))
                    {
                        _dbSet.RemoveRange(query);
                    }
                }

                if (entities != null && entities.Length > 0)
                {
                    _dbSet.RemoveRange(entities);
                }

                return await SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while removing entities of type {EntityType}.", typeof(T).Name);
                return false;
            }
        }

        /// <summary>
        /// Inserts entities into the database asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="entities">The entities to insert.</param>
        /// <returns>True if entities were inserted successfully; otherwise, false.</returns>
        private async Task<bool> InsertAsync(CancellationToken cancellationToken = default, params T[] entities)
        {
            if (entities.Length == 0)
            {
                _logger.LogWarning("InsertAsync called with no parameters. No action taken.");
                return true;
            }

            await _dbSet.AddRangeAsync(entities, cancellationToken);
            return await SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Updates entities in the database asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="entities">The entities to update.</param>
        /// <returns>True if entities were updated successfully; otherwise, false.</returns>
        private async Task<bool> UpdateAsync(CancellationToken cancellationToken, params T[] entities)
        {
            if (entities.Length == 0)
            {
                _logger.LogWarning("UpdateAsync called with no parameters. No action taken.");
                return true;
            }

            _context.UpdateRange(entities);
            return await SaveChangesAsync(cancellationToken);
        }

        #endregion

        #region Bulk Operations

        public async Task<bool> BulkDeleteAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return await RemoveAsync(cancellationToken, null, entities.ToArray());
        }

        public async Task<bool> BulkInsertAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return await InsertAsync(cancellationToken, entities.ToArray());
        }

        public async Task<bool> BulkUpdateAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return await UpdateAsync(cancellationToken, entities.ToArray());
        }

        #endregion

        #region Delete Operations

        public async Task<bool> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            return await RemoveAsync(cancellationToken, null, entity);
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await RemoveAsync(cancellationToken, x => x.Id == id);
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
        {
            return await RemoveAsync(cancellationToken, filter);
        }

        #endregion

        #region Query Operations

        public async Task<IQueryable<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(_dbSet.AsNoTracking());
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default, params Expression<Func<T, object>>[] includes)
        {
            try
            {
                IQueryable<T> query = _dbSet.AsQueryable();

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (includes != null && includes.Length > 0)
                {
                    foreach (var includeProperty in includes)
                    {
                        query = query.Include(includeProperty);
                    }
                }

                if (orderBy != null)
                {
                    query = orderBy(query);
                }

                return await Task.FromResult(query.AsNoTracking());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving all records of type {EntityType}.", typeof(T).Name);
                return Enumerable.Empty<T>().AsQueryable();
            }
        }

        public async Task<T?> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _dbSet.FindAsync(new { id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return null;
            }
        }

        public async Task<T?> GetAsync(Guid id, Guid companyDataId, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _dbSet.Where(x => x.Id == id && EF.Property<Guid>(x, "CompanyDataId") == companyDataId).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return null;
            }
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _dbSet.FirstOrDefaultAsync(filter, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return null;
            }
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _dbSet.CountAsync(filter, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return 0;
            }
        }

        #endregion

        #region Insert Operations

        public async Task<Guid> InsertAndReturnIdAsync(T entity, CancellationToken cancellationToken = default)
        {
            try
            {
                await _dbSet.AddAsync(entity, cancellationToken);
                var result = await _context.SaveChangesAsync(cancellationToken);
                if (result > 0)
                {
                    return entity.Id;
                }
                throw new InvalidOperationException("There was an internal server error while trying to insert this entity.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inserting entity.");
                return Guid.Empty;
            }
        }

        public async Task<bool> InsertAsync(T entity, CancellationToken cancellationToken = default)
        {
            try
            {
                await _dbSet.AddAsync(entity, cancellationToken);
                return await SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inserting entity.");
                return false;
            }
        }

        #endregion

        #region Update Operations

        public async Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            try
            {
                _dbSet.Update(entity);
                return await SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating entity.");
                return false;
            }
        }

        public async Task<bool> UpdateWithConcurrencyAsync(T entity, CancellationToken cancellationToken = default)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                var existingEntity = await _dbSet.FindAsync(new { entity.Id }, cancellationToken);
                if (existingEntity == null)
                {
                    _logger.LogWarning("Entity not found for update.");
                    return false;
                }

                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, "Concurrency conflict detected while updating entity.");
                await transaction.RollbackAsync(cancellationToken);
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error occurred during update.");
                await transaction.RollbackAsync(cancellationToken);
                return false;
            }
        }

        #endregion

        #region Paged and Filtered Queries

        public async Task<PageResult<T>> GetFilteredAsync(int pageSize, int currentPage, Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default, params Expression<Func<T, object>>[] includes)
        {
            if (pageSize <= 0) throw new ArgumentException("Page size must be greater than 0", nameof(pageSize));
            if (currentPage < 1) throw new ArgumentException("Current page must be greater than 0", nameof(currentPage));

            IQueryable<T> query = _dbSet;

            if (includes is { Length: > 0 })
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            int totalCount = await query.CountAsync(cancellationToken);

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            query = query.Skip((currentPage - 1) * pageSize).Take(pageSize);

            var result = await query.ToListAsync(cancellationToken);

            return new PageResult<T>(result)
            {
                TotalCount = totalCount,
                PageSize = pageSize,
                CurrentPage = currentPage
            };
        }

        public async Task<T?> GetAsync(
            Guid id = default,
            Guid companyDataId = default,
            Expression<Func<T, bool>>? filter = null,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;


            if (includes != null && includes.Any())
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }


            if (id != default)
            {
                query = query.Where(x => EF.Property<Guid>(x, "Id") == id);
            }


            if (companyDataId != default)
            {
                query = query.Where(x => EF.Property<Guid>(x, "CompanyDataId") == companyDataId);
            }


            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.FirstOrDefaultAsync();
        }


        public async Task<T?> GetFirstOrDefaultAsync(
            Expression<Func<T, bool>> filter,
            CancellationToken cancellationToken = default)
        {
            return await _dbSet.FirstOrDefaultAsync(filter, cancellationToken);
        }


        public async Task<T?> GetLastOrDefaultAsync(
            Expression<Func<T, bool>> filter,
            CancellationToken cancellationToken = default)
        {

            return await _dbSet.Where(filter)
                   .LastOrDefaultAsync();

        }

        public async Task<PageResult<T>> GetPagedAsync(int pageSize, int currentPage, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            CancellationToken cancellationToken = default)
        {
            if (currentPage < 1)
            {
                currentPage = 1;
            }

            IQueryable<T> query = _dbSet;



            int totalCount = await query.CountAsync(cancellationToken);


            if (orderBy != null)
            {
                query = orderBy(query);
            }



            var items = await query.Skip((currentPage - 1) * pageSize)
                                   .Take(pageSize)
                                   .ToListAsync(cancellationToken);

            return new PageResult<T>(items)
            {

                TotalCount = totalCount,
                CurrentPage = currentPage,
                PageSize = pageSize
            };
        }

        #endregion
    }
}