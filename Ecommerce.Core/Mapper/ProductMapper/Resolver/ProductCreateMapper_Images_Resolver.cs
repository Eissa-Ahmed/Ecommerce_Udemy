namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductCreateMapper_Images_Resolver : IValueResolver<ProductCreateModel, Product, ICollection<Images>>
{
    private readonly IFileFactory _fileFactory;

    public ProductCreateMapper_Images_Resolver(IFileFactory fileFactory)
    {
        _fileFactory = fileFactory;
    }

    public ICollection<Images> Resolve(ProductCreateModel source, Product destination, ICollection<Images> destMember, ResolutionContext context)
    {
        ICollection<Images> images = new List<Images>();
        foreach (var file in source.Images)
        {
            Images image = new Images
            {
                Name = _fileFactory.GetFileService(file).SaveFileAsync(file),
                Size = file.Length
            };
            images.Add(image);
        }
        return images;
    }
}

