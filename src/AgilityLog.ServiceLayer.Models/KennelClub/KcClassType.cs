
namespace AgilityLog.ServiceLayer.Models.KennelClub
{
    using System;

    [Flags]
    public enum KcClassType
    {
        None = 0,
        Agility = ClassType.Agility & KcClassCategory.Standard,
        Jumping = ClassType.Jumping & KcClassCategory.Standard,
        Special = KcClassCategory.Special
    }
}