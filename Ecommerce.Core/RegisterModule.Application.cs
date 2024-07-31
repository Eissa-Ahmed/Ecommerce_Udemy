using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Application;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Application(this IServiceCollection services, IConfigurationManager configuration)
    {
        return services;
    }
}
