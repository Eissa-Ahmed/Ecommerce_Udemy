using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Ecommerce.API;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Api(this IServiceCollection services, WebApplicationBuilder builder)
    {
        builder.Services.AddControllers(opt =>
        {
            //opt.Filters.Add<ValidationFilter>();

        }).AddJsonOptions(option => option.JsonSerializerOptions.PropertyNamingPolicy = null);

        registerSwaggerGen(builder);
        registerIdentity(builder);
        registerVersioning(builder);
        registerCorsOrigin(builder);
        readFilesFromAppSettings(builder);
        return services;
    }



    private static void registerCorsOrigin(WebApplicationBuilder builder)
    {
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", policy =>
            {
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
                policy.AllowAnyOrigin();
            });
        });
    }

    private static void readFilesFromAppSettings(WebApplicationBuilder builder)
    {
        builder.Services.Configure<FileSettings>(builder.Configuration.GetSection(nameof(FileSettings)));
        builder.Services.Configure<Domain.Models.ApplicationSettingModel>(builder.Configuration.GetSection(nameof(Domain.Models.ApplicationSettingModel)));
        builder.Services.Configure<JWTModel>(builder.Configuration.GetSection(nameof(JWTModel)));
        builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection(nameof(EmailSettings)));
    }

    private static void registerSwaggerGen(WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "API v1", Version = "v1.0", Description = "API v1" });
            c.SwaggerDoc("v2", new OpenApiInfo { Title = "API v2", Version = "v2.0", Description = "API v2" });
            c.EnableAnnotations();

            c.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
            {
                Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer ........')",
                Name = "Authorization",
                In = ParameterLocation.Header,
                //Type = SecuritySchemeType.ApiKey,
                Scheme = JwtBearerDefaults.AuthenticationScheme
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = JwtBearerDefaults.AuthenticationScheme
                        },
                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header
                    },
                    new string[] { }
                }
            });
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
        builder.Services.AddIdentity<User, Role>()
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

            opt.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultProvider;
            opt.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultProvider;
        });
    }
}
