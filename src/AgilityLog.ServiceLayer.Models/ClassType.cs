using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.ServiceLayer.Models
{
    [Flags]
    public enum ClassType
    {
        Agility,
        Jumping,
        Steeplechase,
        Pairs,
        Team,
        Gamblers,
        Snooker,
        TimeFaultAndOut,
        PowerAndSpeed,
        SnakesAndLadders
    }
}
