namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile
{
    private void ApplyProductGetByIdMapper()
    {
        CreateMap<Product, ProductGetByIdResult>()
            .ForMember(dest => dest.MainImage, opt => opt.MapFrom<ProductGetByIdMapper_MainImage_Resolver>())
            .ForMember(dest => dest.TotalRating, opt => opt.MapFrom<ProductGetByIdMapper_Rating_Resolver>())
            .ForMember(dest => dest.Images, opt => opt.MapFrom<ProductGetByIdMapper_Images_Resolver>())
            .ForMember(dest => dest.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttributes))
            .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews))
            .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
            .ForMember(dest => dest.ProductVariant, opt => opt.MapFrom(src => src.ProductVariant))
            .ForMember(dest => dest.CareInstructions, opt => opt.MapFrom(src => src.CareInstructions));

        CreateMap<Images, ProductGetByIdResult_Images>();
        CreateMap<ProductAttributes, ProductGetByIdResult_ProductAttributes>();
        CreateMap<Review, ProductGetByIdResult_Review>();
        CreateMap<Features, ProductGetByIdResult_Features>();
        CreateMap<CareInstructions, ProductGetByIdResult_CareInstructions>();
        CreateMap<ProductVariant, ProductGetByIdResult_ProductVariant>();

    }
}
