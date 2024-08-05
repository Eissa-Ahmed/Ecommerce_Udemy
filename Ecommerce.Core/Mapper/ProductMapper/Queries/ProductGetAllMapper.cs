namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile
{
    private void ApplyProductGetAllMapper()
    {
        CreateMap<Product, ProductGetAllResult>()
            .ForMember(dest => dest.Rating, opt => opt.MapFrom<RatingProductResolver>());
    }
}
