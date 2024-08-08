using ExpenseTracker.Core.ClientModels;
using ExpenseTracker.Core.DBModels;
using ExpenseTracker.Data;

namespace ExpenseTracker.Service;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<UserProfileModel> GetUserByIdAsync(int userId)
    {
        var user = await userRepository.GetUserByIdAsync(userId);
        return user != null ? mapToUserProfileModel(user) : null;
    }

    

    // Mapping methods
    private UserProfileModel mapToUserProfileModel(UserProfile userProfile)
    {
        return new UserProfileModel
        {
            UserId = userProfile.UserId,
            DisplayName = userProfile.DisplayName,
            FirstName = userProfile.FirstName,
            LastName = userProfile.LastName,
            Email = userProfile.Email,
            AddObjId = userProfile.AddObjId,
            FamilyId = userProfile.FamilyId
        };
    }
}
