namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile
{
    private void ApplyProductCreateMapper()
    {
        CreateMap<ProductCreateModel, Product>()
            .ForMember(dest => dest.ProductAttributes, opt => opt.Ignore())
            .ForMember(dest => dest.Images, opt => opt.Ignore());

        CreateMap<ProductCreateModel_ProductAttributes, ProductAttributes>();

        CreateMap<Product, ProductCreateResult>()
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
            .ForMember(dest => dest.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttributes));

        CreateMap<Images, ProductCreateResult_Images>();
        CreateMap<ProductAttributes, ProductCreateResult_ProductAttributes>();

    }
}
