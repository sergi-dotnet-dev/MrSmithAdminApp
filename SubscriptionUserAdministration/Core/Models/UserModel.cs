namespace SubscriptionUserAdministration.Core.Models;

[Serializable]
public sealed class UserModel
{

    public Int32 Id { get; private set; }
    public String Name { get; private set; }
    public String LastName { get; private set; }
    public String PhoneNumber { get; private set; }
    public Boolean IsExpired { get; private set; }
    public DateTime SubExpiriationDate { get; private set; }

    public UserModel(Int32 id, String name, String lastName, String phoneNumber, DateTime subExpiriationDate, Boolean isExpired = false)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        IsExpired = isExpired;
        SubExpiriationDate = subExpiriationDate;
    }
}