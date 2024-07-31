namespace Ecommerce.Infrastucture;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Infrastructure(this IServiceCollection services, IConfigurationManager configuration)
    {
        registerStoreContext(services, configuration);
        registerDependencyInjection(services);
        registerIdentity(services);
        return services;
    }

    private static void registerIdentity(IServiceCollection services)
    {
        services.AddIdentityCore<Users>();
        services.Configure<IdentityOptions>(opt =>
        {
            opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            opt.User.RequireUniqueEmail = true;

            opt.Password.RequireDigit = false;
            opt.Password.RequireLowercase = false;
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequireUppercase = false;
            opt.Password.RequiredLength = 6;
            opt.Password.RequiredUniqueChars = 0;
        });
    }

    private static void registerDependencyInjection(IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }

    private static void registerStoreContext(IServiceCollection services, IConfigurationManager configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}
