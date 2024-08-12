namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductCreateMapper_ProdutImage_Resolver : IValueResolver<Product, ProductCreateResult, string>
{
    private readonly IOptions<ApplicationSettings> _settings;

    public ProductCreateMapper_ProdutImage_Resolver(IOptions<ApplicationSettings> settings)
    {
        _settings = settings;
    }

    public string Resolve(Product source, ProductCreateResult destination, string destMember, ResolutionContext context)
    {
        return $"{_settings.Value.ApiUrl}{source.MainImage}";
    }
}
