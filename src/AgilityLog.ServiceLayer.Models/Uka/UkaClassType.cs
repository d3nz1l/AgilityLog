namespace AgilityLog.ServiceLayer.Models.Uka
{
    public enum UkaClassType
    {
        Undefined,
        Agility = ClassType.Agility & UkaClassCategory.Performance,
        Jumping = ClassType.Jumping & UkaClassCategory.Performance,
        Steeplechase = ClassType.Steeplechase & UkaClassCategory.Steeplechase,
        Games = UkaClassCategory.Performance,
        Special = UkaClassCategory.Special
    }
}