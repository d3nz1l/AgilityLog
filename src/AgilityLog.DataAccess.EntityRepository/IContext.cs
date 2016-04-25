using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace AgilityLog.DataAccess.EntityRepository
{
    public interface IContext : IDisposable
    {
        /// <summary>
        /// Gets the <see cref="DbSet"/> for the entity type.
        /// </summary>
        /// <typeparam name="TEntity">The type of entity.</typeparam>
        /// <returns>The <see cref="DbSet"/> the given entity type.</returns>
        DbSet<TEntity> EntitySet<TEntity>() where TEntity : class;
    }
}
