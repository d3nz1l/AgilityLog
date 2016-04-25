using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.ServiceLayer.Models.KennelClub
{
    /// <summary>
    /// Represents the classes category, i.e. Standard or Special
    /// </summary>
    [Flags]
    public enum KcClassCategory
    {
        None,
        Standard,
        Special
    }
}
