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
            //.ForMember(dest => dest.Ratings, opt => opt.MapFrom(src => src.Ratings))
            .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews))
            .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
            .ForMember(dest => dest.CareInstructions, opt => opt.MapFrom(src => src.CareInstructions));
        //.ForMember(dest => dest.ProductColors, opt => opt.MapFrom(src => src.ProductColors));

        CreateMap<Images, ProductGetByIdResult_Images>();
        CreateMap<ProductAttributes, ProductGetByIdResult_ProductAttributes>();
        CreateMap<Review, ProductGetByIdResult_Review>();
        //CreateMap<Rating, ProductGetByIdResult_Rating>();
        CreateMap<Features, ProductGetByIdResult_Features>();
        CreateMap<CareInstructions, ProductGetByIdResult_CareInstructions>();
        /*CreateMap<ProductColors, ProductGetByIdResult_ProductColors>()
            .ForMember(dest => dest.ProductSizes, opt => opt.MapFrom(src => src.ProductSizes));*/

        //CreateMap<ProductSizes, ProductGetByIdResult_ProductSizes>();

    }
}
