using ExpenseTracker.Data;
using ExpenseTracker.Service;

namespace ExpenseTracker.Web;

public static class ServicesDI
{
    // 'this' keyword indicates that this is an extension method for IServiceCollection
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}
