using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AgilityLog.DataAccess.Entities;

namespace AgilityLog.DataAccess.EntityRepository.Repositories
{
    /// <summary>
    /// Represents a data access repository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TIdentifier">The type of the identifier.</typeparam>
    public interface IEntityRepository<TEntity, TIdentifier>
        where TEntity : EntityBase<TIdentifier>
        where TIdentifier : IComparable
    {
        /// <summary>
        /// Gets model based on the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The model</returns>
        Task<TEntity> GetAsync(TIdentifier id);

        /// <summary>
        /// Gets all models.
        /// </summary>
        /// <returns>All models</returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Gets the by asynchronous.
        /// </summary>
        /// <param name="filterExpression">The filter expression.</param>
        /// <returns>All models matching the expression</returns>
        Task<TEntity> GetByAsync(Expression<Func<TEntity, bool>> filterExpression);

        /// <summary>
        /// Adds the model.
        /// </summary>
        /// <param name="entity">The model.</param>
        /// <returns>Async task</returns>
        Task AddAsync(TEntity model);

        /// <summary>
        /// Adds the models.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Async task</returns>
        Task AddAsync(IEnumerable<TEntity> model);

        /// <summary>
        /// Updates the model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Async task</returns>
        Task UpdateAsync(TEntity model);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Async task</returns>
        Task UpdateAsync(IEnumerable<TEntity> model);

        /// <summary>
        /// Deletes the model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Async task</returns>
        Task DeleteAsync(TEntity model);
    }
}
