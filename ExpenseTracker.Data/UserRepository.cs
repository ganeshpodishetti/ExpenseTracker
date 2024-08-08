using ExpenseTracker.Core.DBModels;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data;

public class UserRepository : IUserRepository
{
    private readonly ExpenseTrackerDbContext _dbContext;
    // Constructor
    public UserRepository(ExpenseTrackerDbContext expenseTrackerDbContext)
    {
        _dbContext = expenseTrackerDbContext;
    }

    public Task AddFamilyAsync(Family family)
    {
        _dbContext.Families.Add(family);
        return _dbContext.SaveChangesAsync();
    }

    public Task AddUserAsync(UserProfile user)
    {
        _dbContext.UserProfiles.Add(user);
        return _dbContext.SaveChangesAsync();
    }

    public async Task DeleteFamilyAsync(int familyId)
    {
        var family = await _dbContext.Families.FindAsync(familyId);
        if (family != null)
        {
            _dbContext.Families.Remove(family);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task DeleteUserAsync(int userId)
    {
        var user = await _dbContext.UserProfiles.FindAsync(userId);
        if (user != null)
        {
            _dbContext.UserProfiles.Remove(user);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Family>> GetAllFamilyAsync()
    {
        return await _dbContext.Families.ToListAsync();
    }

    public async Task<Family> GetFamilyByIdAsync(int familyId)
    {
        return await _dbContext.Families.FindAsync(familyId);
    }

    public async Task<IEnumerable<UserProfile>> GetUserByFamilyIdAsync(int familyId)
    {
        return await _dbContext.UserProfiles.Where(u => u.FamilyId == familyId).ToListAsync();
    }

    public async Task<UserProfile> GetUserByIdAsync(int userId)
    {
        var userProfile = await _dbContext.UserProfiles.FindAsync(userId);
        // if (userProfile == null) return userProfile;
        return userProfile;
    }

    public Task UpdateFamilyAsync(Family family)
    {
        _dbContext.Families.Update(family);
        return _dbContext.SaveChangesAsync();
    }

    public Task UpdateUserAsync(UserProfile user)
    {
        _dbContext.UserProfiles.Update(user);
        return _dbContext.SaveChangesAsync();
    }
}
