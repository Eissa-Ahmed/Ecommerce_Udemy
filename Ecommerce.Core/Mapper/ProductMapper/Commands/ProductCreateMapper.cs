namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile
{
    private void ApplyProductCreateMapper()
    {
        CreateMap<ProductCreateModel, Product>()
            .ForMember(dest => dest.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttributes))
            .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
            .ForMember(dest => dest.CareInstructions, opt => opt.MapFrom(src => src.CareInstructions))
            .ForMember(dest => dest.ProductVariant, opt => opt.MapFrom(src => src.ProductVariants))
            .ForMember(dest => dest.Images, opt => opt.MapFrom<ProductCreate_ConvertIFormFilesToImages_Resolver>());

        CreateMap<ProductCreateModel_ProductAttributes, ProductAttributes>();
        CreateMap<ProductCreateModel_CareInstructions, CareInstructions>();
        CreateMap<ProductCreateModel_Features, Features>();
        CreateMap<ProductCreateModel_ProductVariant, ProductVariant>()
            .ForMember(dest => dest.Size, opt => opt.MapFrom(src => Enum.Parse<ProductSize>(src.Size)));


        CreateMap<Product, ProductCreateResult>()
            .ForMember(dest => dest.MainImage, opt => opt.MapFrom<ProductCreate_ConvertMainImageToUrl_Resolver>())
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
            .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
            .ForMember(dest => dest.CareInstructions, opt => opt.MapFrom(src => src.CareInstructions))
            .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.Name))
            .ForMember(dest => dest.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttributes));

        CreateMap<Images, ProductCreateResult_Images>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom<ProductCreate_ConvertImagesToUrls_Resolver>());

        CreateMap<ProductVariant, ProductCreateResult_ProductVariant>()
            .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Size.ToString()));


        CreateMap<ProductAttributes, ProductCreateResult_ProductAttributes>()
           .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Attributes.Name));

        CreateMap<Features, ProductCreateResult_Features>();
        CreateMap<CareInstructions, ProductCreateResult_CareInstructions>();

    }
}
