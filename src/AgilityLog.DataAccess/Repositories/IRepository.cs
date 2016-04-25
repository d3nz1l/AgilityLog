using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AgilityLog.DataAccess.Repositories
{
    /// <summary>
    /// Represents a data access repository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TIdentifier">The type of the identifier.</typeparam>
    public interface IRepository<TModel, TEntity, TIdentifier>
        where TModel : class
        where TEntity : class
        where TIdentifier : IComparable
    {
        /// <summary>
        /// Gets model based on the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The model</returns>
        Task<TModel> GetAsync(TIdentifier id);

        /// <summary>
        /// Gets all models.
        /// </summary>
        /// <returns>All models</returns>
        Task<IEnumerable<TModel>> GetAllAsync();

        /// <summary>
        /// Gets the by asynchronous.
        /// </summary>
        /// <param name="filterExpression">The filter expression.</param>
        /// <returns>All models matching the expression</returns>
        Task<TModel> GetByAsync(Expression<Func<TEntity, bool>> filterExpression);

        /// <summary>
        /// Adds the model.
        /// </summary>
        /// <param name="entity">The model.</param>
        /// <returns>Async task</returns>
        Task AddAsync(TModel model);

        /// <summary>
        /// Adds the models.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Async task</returns>
        Task AddAsync(IEnumerable<TModel> model);

        /// <summary>
        /// Updates the model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Async task</returns>
        Task UpdateAsync(TModel model);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Async task</returns>
        Task UpdateAsync(IEnumerable<TModel> model);

        /// <summary>
        /// Deletes the model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Async task</returns>
        Task DeleteAsync(TModel model);
    }
}
