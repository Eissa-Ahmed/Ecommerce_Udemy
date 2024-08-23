namespace Ecommerce.Application.Mapper.OfferMapper;

public partial class OfferProfile
{
    private void ApplyOfferGetAllMapper()
    {
        CreateMap<Pagination<Discount>, Pagination<OfferGetAllResult>>()
            .ForMember(des => des.Data, opt => opt.MapFrom(src => src.Data));

        CreateMap<Discount, OfferGetAllResult>()
            .ForMember(des => des.DiscountImageUrl, opt => opt.MapFrom<OfferGetAll_ConvertImageNameToUrl_Resolver>());

    }
}
