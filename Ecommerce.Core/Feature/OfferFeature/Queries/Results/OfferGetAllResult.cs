namespace Ecommerce.Application.Feature.OfferFeature.Queries.Results;

public sealed class OfferGetAllResult
{
    public string Id { get; set; } = null!;
    public string DiscountName { get; set; } = null!;
    public string DiscountImageUrl { get; set; } = null!;
    public decimal DiscountPercentage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
