using ModelsUpgrade.Apstractions;
using Repositories.Result;
using System.Linq.Expressions;

namespace Logic.Interfaces;

/// <summary>
/// Represents a generic service interface for standard CRUD operations.
/// This service supports extra contextual parameters (CompanyDataId and BranchDataId) to accommodate entities 
/// that require additional filtering or association information.
/// </summary>
/// <typeparam name="T">
/// The entity type. This type must inherit from <see cref="Entity"/> and have a parameterless constructor.
/// </typeparam>
/// <typeparam name="TDto">
/// The Data Transfer Object (DTO) type associated with the entity.
/// </typeparam>
public interface IService<T, TDto>
    where T : Entity, new()
{
    #region Get Methods

    /// <summary>
    /// Retrieves a collection of DTOs.
    /// Optionally, you can filter by CompanyDataId and/or BranchDataId, or use an additional filter expression.
    /// </summary>
    Task<IEnumerable<TDto>> GetAllAsync(
        Guid? companyDataId = null,
        Guid? branchDataId = null,
        Expression<Func<TDto, bool>>? filter = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a single DTO by its unique identifier.
    /// </summary>
    Task<TDto?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a single DTO by its unique identifier and associated CompanyDataId and BranchDataId.
    /// </summary>
    Task<TDto?> GetByIdAsync(
        Guid id,
        Guid? companyDataId = null,
        Guid? branchDataId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a filtered collection of DTOs.
    /// </summary>
    Task<IEnumerable<TDto>> GetFilteredAsync(
        Expression<Func<TDto, bool>> filter,
        Guid? companyDataId = null,
        Guid? branchDataId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a paged collection of DTOs.
    /// </summary>
    Task<PageResult<TDto>> GetPagedAsync(
        int pageSize,
        int currentPage,
        Expression<Func<TDto, bool>>? filter = null,
        Guid? companyDataId = null,
        Guid? branchDataId = null,
        CancellationToken cancellationToken = default);

    #endregion

    #region Insert Methods

    /// <summary>
    /// Inserts a new DTO into the data store.
    /// </summary>
    Task<bool> InsertAsync(
        TDto item,
        string userId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Inserts a new DTO with associated CompanyDataId and BranchDataId.
    /// </summary>
    Task<bool> InsertAsync(
        TDto item,
        string userId,
        Guid? companyDataId = null,
        Guid? branchDataId = null,
        CancellationToken cancellationToken = default);

    #endregion

    #region Update Methods

    /// <summary>
    /// Updates an existing DTO.
    /// </summary>
    Task<bool> UpdateAsync(
        TDto item,
        string userId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing DTO with associated CompanyDataId and BranchDataId.
    /// </summary>
    Task<bool> UpdateAsync(
        TDto item,
        string userId,
        Guid? companyDataId = null,
        Guid? branchDataId = null,
        CancellationToken cancellationToken = default);

    #endregion

    #region Delete Methods

    /// <summary>
    /// Deletes a DTO by its unique identifier.
    /// </summary>
    Task<bool> DeleteByIdAsync(
        Guid id,
        string userId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a DTO by its unique identifier and associated CompanyDataId and BranchDataId.
    /// </summary>
    Task<bool> DeleteByIdAsync(
        Guid id,
        string userId,
        Guid? companyDataId = null,
        Guid? branchDataId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a DTO directly by the item.
    /// </summary>
    Task<bool> DeleteAsync(
        TDto item,
        string userId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a DTO directly by the item with associated CompanyDataId and BranchDataId.
    /// </summary>
    Task<bool> DeleteAsync(
        TDto item,
        string userId,
        Guid? companyDataId = null,
        Guid? branchDataId = null,
        CancellationToken cancellationToken = default);

    #endregion
}
