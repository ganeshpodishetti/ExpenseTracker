using ExpenseTracker.Core.DBModels;

namespace ExpenseTracker.Data;

public interface IUserRepository
{
    Task<UserProfile> GetUserByIdAsync(int userId);
    Task<IEnumerable<UserProfile>> GetUserByFamilyIdAsync(int familyId);
    Task AddUserAsync(UserProfile user);
    Task UpdateUserAsync(UserProfile user);
    Task DeleteUserAsync(int userId);

    Task<Family> GetFamilyByIdAsync(int familyId);
    Task<IEnumerable<Family>> GetAllFamilyAsync();
    Task AddFamilyAsync(Family family);
    Task UpdateFamilyAsync(Family family);
    Task DeleteFamilyAsync(int familyId);
}