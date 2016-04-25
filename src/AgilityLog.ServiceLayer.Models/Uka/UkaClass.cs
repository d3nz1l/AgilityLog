using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.ServiceLayer.Models.Uka
{
    /// <summary>
    /// Repesents a UKA class
    /// </summary>
    public class UkaClass
    {
        public UkaJumpHeight JumpHeight { get; set; }

        public UkaClassType Type { get; set; }

        public UkaGrade IncluedGrades { get; set; }
    }
}
