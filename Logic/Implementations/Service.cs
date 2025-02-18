

using AutoMapper;
using DTOs;
using Logic.Interfaces;
using Microsoft.Extensions.Logging;
using ModelsUpgrade.Apstractions;
using Repositories.Interfaces;
using Repositories.Result;
using System.Linq.Expressions;

namespace Logic.Implementations
{
    public class Service<T, TDto> : IService<T, TDto>
            where T : Entity, new()
            where TDto : DTO, new()
    {
        private readonly ILogger<Service<T, TDto>> _logger;
        private readonly IRepository2<T> _repository;
        private readonly IMapper _mapper;

        public Service(ILogger<Service<T, TDto>> logger, IRepository2<T> repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync(TDto item, string userId, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = _mapper.Map<T>(item);
                entity.DeletedDate = DateTime.UtcNow;
                entity.DeletedBy = userId;
                entity.IsNotActive = true;
                entity.IsDeleted = true;
                return await _repository.UpdateAsync(entity, cancellationToken);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return false;
            }

        }
        private async Task<bool> DeleteByCompanyIdAsync(TDto item, string userId, Guid companyDataId, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await _repository.GetAsync(item.Id, companyDataId);
                if (entity == null)
                {
                    return false;
                }
                entity.DeletedDate = DateTime.UtcNow;
                entity.DeletedBy = userId;
                entity.IsNotActive = true;
                entity.IsDeleted = true;
                return await _repository.UpdateAsync(entity, cancellationToken);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return false;
            }
        }
        private Expression<Func<T, bool>> MapBranch(Guid branchDataId)
        {
            var parameter = Expression.Parameter(typeof(TDto), "x");
            var property = Expression.Property(parameter, "BranchDataId");
            if (property == null)
            {
                throw new InvalidOperationException("The property 'BranchDataId' was not found.");
            }

            var condition = Expression.Equal(property, Expression.Constant(branchDataId));
            return Expression.Lambda<Func<T, bool>>(condition, parameter);

        }
        private Expression<Func<T, bool>> MapCompany(Guid companyDataId)
        {
            var parameter = Expression.Parameter(typeof(TDto), "x");
            var property = Expression.Property(parameter, "CompanyDataId");
            if (property == null)
            {
                throw new InvalidOperationException("The property 'CompanyDataId' was not found.");
            }

            var condition = Expression.Equal(property, Expression.Constant(companyDataId));
            return Expression.Lambda<Func<T, bool>>(condition, parameter);

        }
        private Expression<Func<T, bool>> MapBranchAndCompany(Guid branchDataId, Guid companyDataId)
        {
            try
            {
                var branchExpression = MapBranch(branchDataId);
                var companyExpression = MapCompany(companyDataId);

                var andExpression = Expression.AndAlso(branchExpression, companyExpression);
                return Expression.Lambda<Func<T, bool>>(andExpression);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }

        }
        private async Task<bool> DeleteByCompanyIdAsync(TDto item, string userId, Guid companyDataId, Guid branchDataId, CancellationToken cancellationToken)
        {
            try
            {
                var expression = MapBranch(branchDataId);

                var entity = await _repository.GetAsync(item.Id, companyDataId, expression);
                if (entity == null)
                {
                    return false;
                }
                entity.DeletedDate = DateTime.UtcNow;
                entity.DeletedBy = userId;
                entity.IsNotActive = true;
                entity.IsDeleted = true;
                return await _repository.UpdateAsync(entity, cancellationToken);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return false;
            }
        }
        public async Task<bool> DeleteAsync(TDto item, string userId, Guid? companyDataId = null, Guid? branchDataId = null, CancellationToken cancellationToken = default)
        {
            try
            {

                Guid companyId = Guid.Empty;
                Guid branchId = Guid.Empty;
                if (companyDataId != null && branchDataId == null)
                {
                    companyId = companyDataId.Value;
                    return await DeleteByCompanyIdAsync(item, userId, companyId, cancellationToken);
                }
                if (branchDataId != null && companyDataId != null)
                {
                    companyId = companyDataId.Value;
                    branchId = branchDataId.Value;
                    return await DeleteByCompanyIdAsync(item, userId, companyId, branchId, cancellationToken);
                }
                return await DeleteAsync(item, userId, cancellationToken);


            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteByIdAsync(Guid id, string userId, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repository.GetAsync(id);
                if (entity == null)
                {
                    throw new IndexOutOfRangeException($"there is non entity has this id: {id}");
                }
                entity.DeletedDate = DateTime.UtcNow;
                entity.DeletedBy = userId;
                entity.IsNotActive = true;
                entity.IsDeleted = true;
                return await _repository.UpdateAsync(entity, cancellationToken);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;

            }
        }

        public async Task<bool> DeleteByIdAsync(Guid id, string userId, Guid? companyDataId = null, Guid? branchDataId = null, CancellationToken cancellationToken = default)
        {
            try
            {
                T? entity = null;
                if (companyDataId == null && branchDataId == null)
                {
                    return await DeleteByIdAsync(id, userId, cancellationToken);
                }
                if (companyDataId != null && branchDataId == null)
                {
                    entity = await _repository.GetAsync(id, Guid.Parse(companyDataId.ToString()), cancellationToken);

                }
                if (companyDataId == null && branchDataId != null)
                {
                    var expression = MapBranch(Guid.Parse(branchDataId.ToString()));
                    entity = await _repository.GetAsync(id, cancellationToken);
                }
                if (entity == null)
                {
                    return false;
                }
                entity.DeletedDate = DateTime.UtcNow;
                entity.DeletedBy = userId;
                entity.IsNotActive = true;
                entity.IsDeleted = true;
                return await _repository.UpdateAsync(entity, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;
            }
        }

        public async Task<IEnumerable<TDto>> GetAllAsync(Guid? companyDataId = null, Guid? branchDataId = null, Expression<Func<TDto, bool>>? filter = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var entities = await _repository.GetAllAsync();
                //there is two proposal implementations filter in server or in database
                //var dEntities = _mapper.Map<IEnumerable<TDto>>(entites);
                if (companyDataId != null && branchDataId == null)
                {
                    return _mapper.Map<IEnumerable<TDto>>(entities.Where(MapCompany(Guid.Parse(companyDataId.ToString()))));
                }
                if (companyDataId == null && branchDataId != null)
                {
                    return _mapper.Map<IEnumerable<TDto>>(entities.Where(MapBranch(Guid.Parse(branchDataId.ToString()))));

                }
                if (companyDataId != null && branchDataId != null)
                {
                    return _mapper.Map<IEnumerable<TDto>>(entities.Where(MapBranchAndCompany(
                        Guid.Parse(branchDataId.ToString())
                        , Guid.Parse(companyDataId.ToString()))
                        )
                        );
                }
                return _mapper.Map<IEnumerable<TDto>>(entities);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return Enumerable.Empty<TDto>();
            }
        }


        public async Task<TDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                return _mapper.Map<TDto>(await _repository.GetAsync(id, cancellationToken));
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return null;
            }
        }

        public Task<TDto?> GetByIdAsync(Guid id, Guid? companyDataId = null, Guid? branchDataId = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TDto>> GetFilteredAsync(Expression<Func<TDto, bool>> filter, Guid? companyDataId = null, Guid? branchDataId = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<TDto>> GetPagedAsync(int pageSize, int currentPage, Expression<Func<TDto, bool>>? filter = null, Guid? companyDataId = null, Guid? branchDataId = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(TDto item, string userId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(TDto item, string userId, Guid? companyDataId = null, Guid? branchDataId = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TDto item, string userId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TDto item, string userId, Guid? companyDataId = null, Guid? branchDataId = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}