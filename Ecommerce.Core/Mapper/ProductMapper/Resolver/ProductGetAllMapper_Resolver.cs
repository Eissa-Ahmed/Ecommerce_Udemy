namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductGetAllMapper_Resolver : IValueResolver<Product, ProductGetAllResult, string>
{
    private readonly IOptions<ApplicationSettings> _settings;

    public ProductGetAllMapper_Resolver(IOptions<ApplicationSettings> settings)
    {
        _settings = settings;
    }

    public string Resolve(Product source, ProductGetAllResult destination, string destMember, ResolutionContext context)
    {
        return $"{_settings.Value.ApiUrl}{source.MainImage}";
    }
}
