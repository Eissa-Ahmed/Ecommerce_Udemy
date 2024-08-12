namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductGetByIdMapper_Images_Resolver : IValueResolver<Product, ProductGetByIdResult, ICollection<ProductGetByIdResult_Images>>
{
    private readonly IOptions<ApplicationSettings> _settings;

    public ProductGetByIdMapper_Images_Resolver(IOptions<ApplicationSettings> settings)
    {
        _settings = settings;
    }

    public ICollection<ProductGetByIdResult_Images> Resolve(Product source, ProductGetByIdResult destination, ICollection<ProductGetByIdResult_Images> destMember, ResolutionContext context)
    {
        ICollection<ProductGetByIdResult_Images> images = new List<ProductGetByIdResult_Images>();
        foreach (var image in source.Images)
        {
            images.Add(new ProductGetByIdResult_Images
            {
                Id = image.Id,
                Name = $"{_settings.Value.ApiUrl}{image.Name}",
                Size = image.Size,
                ProductId = image.ProductId
            });
        }
        return images;
    }
}