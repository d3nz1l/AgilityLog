using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgilityLog.DataAccess.EntityRepository;
using Microsoft.Data.Entity;

namespace AgilityLog.DataAccess.UnitTests.Fakes
{
    public class IContextFake<T> : IContext
        where T : class
    {
        private readonly Func<DbSet<T>> entitySetFunc;

        public IContextFake(Func<DbSet<T>> entitySetFunction)
        {
            this.entitySetFunc = entitySetFunction;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public DbSet<TEntity> EntitySet<TEntity>() where TEntity : class
        {
            return this.entitySetFunc.Invoke() as DbSet<TEntity>;
        }
    }
}
