namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile
{
    private void ApplyProductCreateMapper()
    {
        CreateMap<ProductCreateModel, Product>()
            .ForMember(dest => dest.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttributes))
            .ForMember(dest => dest.Images, opt => opt.MapFrom<ImagesResolver>());

        CreateMap<ProductCreateModel_ProductAttributes, ProductAttributes>();

        CreateMap<Product, ProductCreateResult>()
            .ForMember(dest => dest.MainImage, opt => opt.MapFrom<ProductUrlResolver>())
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
            .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.Name))
            .ForMember(dest => dest.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttributes));

        CreateMap<Images, ProductCreateResult_Images>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom<ImagesUrlResolver>());

        CreateMap<ProductAttributes, ProductCreateResult_ProductAttributes>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Attributes.Name));


    }
}
