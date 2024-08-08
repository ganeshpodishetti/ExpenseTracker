using ExpenseTracker.Core.ClientModels;

namespace ExpenseTracker.Service;

public interface IUserService
{
    // here we need to return a model that should be used by UI/Client who is consuming.
    // But this return model should not be our database model itself. 
    Task<UserProfileModel> GetUserByIdAsync(int userId);
}