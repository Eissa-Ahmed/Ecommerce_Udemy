namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile
{
    private void ApplyProductGetAllMapper()
    {
        CreateMap<Pagination<Product>, Pagination<ProductGetAllResult>>()
            .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data));

        CreateMap<ProductGetAllModel, ProductGetAllParams>()
            .ForMember(des => des.Sort, opt => opt.MapFrom<ProductGetAll_ConvertSortToEnum_Resolver>());


        CreateMap<Product, ProductGetAllResult>()
            .ForMember(dest => dest.Rating, opt => opt.MapFrom<ProductGetAll_ConvertRatingtoDecimal_Resolver>())
            .ForMember(dest => dest.MainImage, opt => opt.MapFrom<ProductGetAll_ConvertMainImageToUrl_Resolver>())
            .ForMember(dest => dest.DiscountPercentage, opt => opt.MapFrom(src => src.Discount == null ? 0 : src.Discount.DiscountPercentage))
            .ForMember(dest => dest.ProductVariant, opt => opt.MapFrom(src => src.ProductVariant));

        CreateMap<ProductVariant, ProductGetAllResult_ProductVariant>()
            .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Size.ToString()));


    }
}
