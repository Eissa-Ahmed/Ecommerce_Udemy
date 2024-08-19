namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductCreate_ConvertImagesToUrls_Resolver : IValueResolver<Images, ProductCreateResult_Images, string>
{
    private readonly IOptions<ApplicationSettings> _settings;

    public ProductCreate_ConvertImagesToUrls_Resolver(IOptions<ApplicationSettings> settings)
    {
        _settings = settings;
    }

    public string Resolve(Images source, ProductCreateResult_Images destination, string destMember, ResolutionContext context)
    {
        return $"{_settings.Value.ApiUrl}{source.Name}";
    }
}
