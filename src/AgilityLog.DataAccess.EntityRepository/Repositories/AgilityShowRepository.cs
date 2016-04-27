using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgilityLog.DataAccess.Entities;

namespace AgilityLog.DataAccess.EntityRepository.Repositories
{
    public class AgilityShowRepository : EntityRepositoryBase<AgilityShow, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgilityShowRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AgilityShowRepository(IContext context) : base(context)
        {
            this.AddIncludes(s => s.Classes);
        }
    }
}
