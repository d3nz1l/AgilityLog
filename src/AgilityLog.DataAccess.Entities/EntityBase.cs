using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.DataAccess.Entities
{
    public class EntityBase<TId>
        where TId : IComparable
    {
        public TId Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is a new object.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is a new object; otherwise, <c>false</c>.
        /// </value>
        public bool IsNewObject
        {
            get
            {
                return this.Id.Equals(default(TId));
            }
        }
    }
}
