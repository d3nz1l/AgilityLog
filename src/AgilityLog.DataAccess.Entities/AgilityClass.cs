using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.DataAccess.Entities
{
    public class AgilityClass : EntityBase
    {
        public string Name { get; set; }

        public int Number { get; set; }

        public string Part { get; set; }

        public int JumpHeight { get; set; }

        public string JudgesName { get; set; }

        public int Type { get; set; }

        public int IncluedGrades { get; set; }

        public int GradeScheme { get; set; }

        public int ShowId { get; set; }
    }
}
