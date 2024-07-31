namespace Ecommerce.Infrastucture;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Infrastructure(this IServiceCollection services, IConfigurationManager configuration)
    {
        registerStoreContext(services, configuration);
        registerDependencyInjection(services);
        return services;
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
