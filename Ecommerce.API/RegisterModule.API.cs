namespace Ecommerce.API;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Api(this IServiceCollection services, WebApplicationBuilder builder)
    {
        builder.Services.AddControllers(opt =>
        {
            opt.Filters.Add<ValidationFilter>();
        });

        registerSwaggerGen(builder);
        registerIdentity(builder);
        registerVersioning(builder);
        return services;
    }

    private static void registerSwaggerGen(WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "API v1", Version = "v1.0", Description = "API v1" });
            c.SwaggerDoc("v2", new OpenApiInfo { Title = "API v2", Version = "v2.0", Description = "API v2" });
        });
    }

    private static void registerVersioning(WebApplicationBuilder builder)
    {
        builder.Services.AddApiVersioning(options =>
        {
            options.ReportApiVersions = true;
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.ApiVersionReader = new UrlSegmentApiVersionReader();
        }).AddApiExplorer(
         options =>
         {
             options.GroupNameFormat = "'v'VVV";
             options.SubstituteApiVersionInUrl = true;
         });
    }

    private static void registerIdentity(WebApplicationBuilder builder)
    {
        builder.Services.AddIdentity<User, IdentityRole>()
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
