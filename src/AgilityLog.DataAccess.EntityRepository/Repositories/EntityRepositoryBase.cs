using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AgilityLog.DataAccess.Entities;
using Microsoft.Data.Entity;

namespace AgilityLog.DataAccess.EntityRepository.Repositories
{
    /// <summary>
    /// Represnt a base implementation of entitt repository.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TIdentifier">The type of the identifier.</typeparam>
    public abstract class EntityRepositoryBase<TEntity, TIdentifier> : IEntityRepository<TEntity, TIdentifier>
        where TEntity : EntityBase<TIdentifier>
        where TIdentifier : IComparable
    {
        private readonly IContext context;

        private readonly IList<Expression<Func<TEntity, object>>> defaultIncludes = new List<Expression<Func<TEntity, object>>>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRepositoryBase{TEntity, TIdentifier}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public EntityRepositoryBase(IContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds the specified models to the context.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// Async task
        /// </returns>
        public virtual Task AddAsync(IEnumerable<TEntity> models)
        {
            var addTasks = models.Select(model => this.AddAsync(model));

            return Task.WhenAll(addTasks);
        }

        /// <summary>
        /// Adds the model.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>
        /// Async task
        /// </returns>
        public virtual Task AddAsync(TEntity model)
        {
            if (!model.IsNewObject)
            {
                return this.UpdateAsync(model);
            }

            return Task.Run(() => this.context.EntitySet<TEntity>().AddRange(model));
        }

        public virtual Task DeleteAsync(TEntity model)
        {
            return Task.Run(() => this.context.EntitySet<TEntity>().Remove(model));
        }

        /// <summary>
        /// Gets all models.
        /// </summary>
        /// <returns>
        /// All models
        /// </returns>
        public async virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await this.GetAllWithIncludes().ToListAsync();
        }

        /// <summary>
        /// Gets model based on the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// The model
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public virtual async Task<TEntity> GetAsync(TIdentifier id)
        {
            return await  this.GetAllWithIncludes().FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        /// <summary>
        /// Gets the entities that match the supplied expression.
        /// </summary>
        /// <param name="filterExpression">The filter expression.</param>
        /// <returns>
        /// All models matching the expression
        /// </returns>
        public virtual async Task<TEntity> GetByAsync(Expression<Func<TEntity, bool>> filterExpression)
        {
            return await this.GetAllWithIncludes().Where(filterExpression).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Updates the entities.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// Async task
        /// </returns>
        public virtual Task UpdateAsync(IEnumerable<TEntity> model)
        {
            return Task.Run(() => this.context.EntitySet<TEntity>().UpdateRange(model));
        }

        /// <summary>
        /// Updates the entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// Async task
        /// </returns>
        public virtual Task UpdateAsync(TEntity model)
        {
            return Task.Run(() => this.context.EntitySet<TEntity>().Update(model));
        }

        /// <summary>
        /// Adds all default includes to the set.
        /// </summary>
        /// <returns></returns>
        private DbSet<TEntity> GetAllWithIncludes()
        {
             var entities = this.context.EntitySet<TEntity>();

            foreach (var include in this.defaultIncludes)
            {
                entities.Include(include);
            }

            return entities;
        }

        /// <summary>
        /// Adds the the set of default include expressions used to specify which properties are populated.
        /// </summary>
        /// <param name="includes">The includes.</param>
        protected void AddIncludes(params Expression<Func<TEntity, object>>[] includes)
        {
            foreach (var include in includes)
            {
                this.defaultIncludes.Add(include);
            }
        }
    }
}
