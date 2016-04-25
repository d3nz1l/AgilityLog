namespace AgilityLog.ServiceLayer.Models.KennelClub
{
    using System;

    /// <summary>
    /// Represents the jump heights 
    /// </summary>
    [Flags]
    public enum KcJumpHeight
    {
        Undefined,
        SmallLowerHeight,
        Small,
        MediumLowerHeight,
        Medium,
        LargeLowerHeight,
        Large
    }
}