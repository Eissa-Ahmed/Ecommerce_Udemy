using Ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.API;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Api(this IServiceCollection services, WebApplicationBuilder builder)
    {
        registerIdentity(builder);
        return services;
    }
    private static void registerIdentity(WebApplicationBuilder builder)
    {
        builder.Services.AddIdentity<Users, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
        builder.Services.Configure<IdentityOptions>(opt =>
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
}
