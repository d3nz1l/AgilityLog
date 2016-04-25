using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.ServiceLayer.Models
{
    /// <summary>
    /// Represents the base properties of an agility class
    /// </summary>
    public abstract class ClassBase : ModelBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the judges.
        /// </summary>
        /// <value>
        /// The name of the judges.
        /// </value>
        public string JudgesName { get; set; }
    }
}
