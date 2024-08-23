namespace Ecommerce.Application.Mapper.OfferMapper.Resolver;

public sealed class OfferGetAll_ConvertImageNameToUrl_Resolver : IValueResolver<Discount, OfferGetAllResult, string>
{
    private readonly IOptions<ApplicationSettings> _applicationSettings;

    public OfferGetAll_ConvertImageNameToUrl_Resolver(IOptions<ApplicationSettings> applicationSettings)
    {
        _applicationSettings = applicationSettings;
    }

    public string Resolve(Discount source, OfferGetAllResult destination, string destMember, ResolutionContext context)
    {
        return $"{_applicationSettings.Value.UiUrl}{source.DiscountImageName}";
    }
}
