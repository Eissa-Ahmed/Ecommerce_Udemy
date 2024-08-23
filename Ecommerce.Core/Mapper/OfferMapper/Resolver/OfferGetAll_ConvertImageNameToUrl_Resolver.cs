namespace Ecommerce.Application.Mapper.OfferMapper.Resolver;

public sealed class OfferGetAll_ConvertImageNameToUrl_Resolver : IValueResolver<Discount, OfferGetAllResult, string>
{
    private readonly IOptions<ApplicationSettingModel> _applicationSettings;

    public OfferGetAll_ConvertImageNameToUrl_Resolver(IOptions<ApplicationSettingModel> applicationSettings)
    {
        _applicationSettings = applicationSettings;
    }

    public string Resolve(Discount source, OfferGetAllResult destination, string destMember, ResolutionContext context)
    {
        return $"{_applicationSettings.Value.ApiUrl}{source.DiscountImageName}";
    }
}
