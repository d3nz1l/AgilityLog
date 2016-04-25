using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.ServiceLayer.Models.KennelClub
{
    /// <summary>
    /// Represents a Kennel Club agility class
    /// </summary>
    public class KcClass : ClassBase
    {
        public int Number { get; set; }

        public string Part { get; set; }

        public KcJumpHeight JumpHeight { get; set; }

        public KcClassType Type { get; set; }

        public KcGrade IncluedGrades { get; set; }

        public KcGradeScheme GradeScheme { get; set; }
    }
}
