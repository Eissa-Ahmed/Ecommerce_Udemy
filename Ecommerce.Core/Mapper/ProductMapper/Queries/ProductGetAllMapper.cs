namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile
{
    private void ApplyProductGetAllMapper()
    {
        CreateMap<Pagination<Product>, Pagination<ProductGetAllResult>>()
            .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data));

        CreateMap<Product, ProductGetAllResult>()
            .ForMember(dest => dest.Rating, opt => opt.MapFrom<RatingProductResolver>())
            .ForMember(dest => dest.MainImage, opt => opt.MapFrom<ProductGetAllMapper_Resolver>());
    }
}
