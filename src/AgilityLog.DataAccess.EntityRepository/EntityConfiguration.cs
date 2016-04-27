using AgilityLog.DataAccess.Entities;
using Microsoft.Data.Entity;

namespace AgilityLog.DataAccess.EntityRepository.Configurations
{
    public abstract class EntityConfiguration<T> : IEntityConfiguration
        where T : EntityBase<int>
    {
        public abstract void Configure(ModelBuilder modelBuilder);
    }
}