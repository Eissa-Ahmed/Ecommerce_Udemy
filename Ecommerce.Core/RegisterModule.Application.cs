
using System.Reflection;

namespace Ecommerce.Application;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Application(this IServiceCollection services, IConfigurationManager configuration)
    {
        registerDependencyInjection(services);
        registerAuutoMapper(services);
        return services;
    }

    private static void registerAuutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }

    private static void registerDependencyInjection(IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryServices, CategoryServices>();
        services.AddScoped<ISubCategoryServices, SubCategoryServices>();
    }
}
