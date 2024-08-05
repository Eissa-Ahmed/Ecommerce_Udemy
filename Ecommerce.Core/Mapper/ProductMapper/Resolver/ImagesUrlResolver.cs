namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ImagesUrlResolver : IValueResolver<Images, ProductCreateResult_Images, string>
{
    private readonly IOptions<ApplicationSettings> _settings;

    public ImagesUrlResolver(IOptions<ApplicationSettings> settings)
    {
        _settings = settings;
    }

    public string Resolve(Images source, ProductCreateResult_Images destination, string destMember, ResolutionContext context)
    {
        return $"{_settings.Value.ApiUrl}{source.Name}";
    }
}
