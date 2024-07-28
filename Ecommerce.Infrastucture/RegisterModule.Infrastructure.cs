

namespace Ecommerce.Infrastucture;

public static class RegisterModule
{
    public static IServiceCollection registerModule_Infrastructure(this IServiceCollection services, IConfigurationManager configuration)
    {
        registerStoreContext(services, configuration);
        return services;
    }

    private static void registerStoreContext(IServiceCollection services, IConfigurationManager configuration)
    {
        services.AddDbContext<StoreContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}
