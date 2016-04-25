namespace AgilityLog.ServiceLayer.Models.KennelClub
{
    using System;

    /// <summary>
    /// represents grades available at KC shows.
    /// </summary>
    [Flags]
    public enum KcGrade
    {
        None,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Champ
    }
}