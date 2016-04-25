using Microsoft.Data.Entity;

namespace AgilityLog.DataAccess.EntityRepository.Configurations
{
    public interface IEntityConfiguration
    {
        void Configure(ModelBuilder modelBuilder);
    }
}