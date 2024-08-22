namespace Ecommerce.Application;

public static class RegisterModule
{
    public static IServiceCollection RegisterModule_Application(this IServiceCollection services, IConfigurationManager configuration)
    {
        registerDependencyInjection(services);
        registerAutoMapper(services);
        registerMediator(services);
        registerFluentValidation(services);
        return services;
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

        services.AddScoped<IDiscountService, DiscountService>();
        services.AddScoped<IDiscountValidation, DiscountValidation>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserValidation, UserValidation>();

        services.AddScoped<IReviewService, ReviewService>();
        services.AddScoped<IReviewValidation, ReviewValidation>();

        services.AddScoped<EmailService>();
        services.AddScoped<NotificationFactory>();

    }
}
