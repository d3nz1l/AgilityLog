using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.DataAccess.Entities
{
    public class AgilityShow : EntityBase<int>
    {
        public string Name { get; set; }

        public IEnumerable<AgilityClass> Classes { get; set; }
    }
}
