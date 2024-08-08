namespace ExpenseTracker.Core.ClientModels;

public class UserProfileModel
{
    public int UserId { get; set; }

    public string DisplayName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string AddObjId { get; set; } = null!;

    public int? FamilyId { get; set; }
}
