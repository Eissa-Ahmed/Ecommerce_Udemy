using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Core;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Core(this IServiceCollection services, IConfigurationManager configuration)
    {
        return services;
    }
}
