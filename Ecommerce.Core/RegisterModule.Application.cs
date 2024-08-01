namespace Ecommerce.Application;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Application(this IServiceCollection services, IConfigurationManager configuration)
    {
        registerDependencyInjection(services);
        return services;
    }

    private static void registerDependencyInjection(IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
    }
}
