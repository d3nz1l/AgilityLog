using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AgilityLog.DataAccess.Entities;
using AgilityLog.DataAccess.EntityRepository.Configurations;
using Microsoft.Data.Entity;

namespace AgilityLog.DataAccess.EntityRepository
{
    public class AgilityLogContext : DbContext, IContext
    {
        private readonly IEntityConfiguration[] configurations;

        /// <summary>
        /// Initializes a new instance of the <see cref="AgilityLogContext"/> class.
        /// </summary>
        /// <param name="configurations">The configurations.</param>
        public AgilityLogContext(IEntityConfiguration[] configurations) : base()
        {
            this.configurations = configurations;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.LoadConfigurations(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Gets or sets the available agility shows.
        /// </summary>
        /// <value>
        /// The shows.
        /// </value>
        public DbSet<AgilityShow> Shows { get; set; }

        /// <summary>
        /// Gets or sets the available agility classes.
        /// </summary>
        /// <value>
        /// The classes.
        /// </value>
        public DbSet<AgilityClass> Classes { get; set; }

        /// <summary>
        /// A simple implementation of an entity type configuration for EF7.
        /// TODO: Implement EF& version when available.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        protected void LoadConfigurations(ModelBuilder modelBuilder)
        {
            foreach (var configuration in configurations)
            {
                configuration.Configure(modelBuilder);
            }
        }

        /// <summary>
        /// Gets the <see cref="DbSet" /> for the entity type.
        /// </summary>
        /// <typeparam name="TEntity">The type of entity.</typeparam>
        /// <returns>
        /// The <see cref="DbSet" /> the given entity type.
        /// </returns>
        public DbSet<TEntity> EntitySet<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }
    }
}
