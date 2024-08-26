namespace Ecommerce.Application;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Application(this IServiceCollection services, IConfigurationManager configuration)
    {
        registerDependencyInjection(services);
        registerAutoMapper(services);
        registerMediator(services);
        registerJwtToken(services, configuration);
        registerFluentValidation(services);
        return services;
    }

    private static void registerJwtToken(IServiceCollection services, IConfigurationManager configuration)
    {
        string? audience = configuration.GetSection("JWTModel:Audience").Value;
        string? issuer = configuration.GetSection("JWTModel:Issuer").Value;
        string? key = configuration.GetSection("JWTModel:Key").Value;
        services.AddAuthentication(auth =>
        {
            auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(opt =>
        {
            opt.RequireHttpsMetadata = false;
            opt.SaveToken = true;
            opt.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = issuer!,
                ValidateAudience = true,
                ValidAudience = audience!,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key!)),
            };
        });
    }

    private static void registerFluentValidation(IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
    }

    private static void registerMediator(IServiceCollection services)
    {
        services.AddMediatR(opt => opt.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }

    private static void registerAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }

    private static void registerDependencyInjection(IServiceCollection services)
    {
        services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
        services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();

        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductValidation, ProductValidation>();

        services.AddScoped<ICategoryServices, CategoryServices>();
        services.AddScoped<ICategoryValidation, CategoryValidation>();
        services.AddScoped<ICategoryHelper, CategoryHelper>();

        services.AddScoped<IFileFactory, FileFactory>();
        services.AddScoped<IFileValidation, FileValidation>();

        services.AddScoped<IProductAttributeService, ProductAttributeService>();
        services.AddScoped<IProductAttributeValidation, ProductAttributeValidation>();

        services.AddScoped<IAttributeService, AttributeService>();
        services.AddScoped<IAttributeValidation, AttributeValidation>();

        services.AddScoped<IBrandService, BrandService>();
        services.AddScoped<IBrandValidation, BrandValidation>();

        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IRequestService, RequestService>();

        services.AddScoped<ITagService, TagService>();
        services.AddScoped<ITagValidation, TagValidation>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserValidation, UserValidation>();

        services.AddScoped<IReviewService, ReviewService>();
        services.AddScoped<IReviewValidation, ReviewValidation>();

        services.AddScoped<IOfferValidation, OfferValidation>();
        services.AddScoped<IOfferService, OfferService>();

        services.AddScoped<IApplicationSettingsService, ApplicationSettingsService>();
        services.AddScoped<IApplicationSettingsValidation, ApplicationSettingsValidation>();

        services.AddScoped<EmailService>();
        services.AddScoped<NotificationFactory>();

    }
}
