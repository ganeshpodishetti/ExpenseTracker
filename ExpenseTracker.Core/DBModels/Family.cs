namespace ExpenseTracker.Core.DBModels;

public partial class Family
{
    public int FamilyId { get; set; }

    public string FamilyName { get; set; } = null!;

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
