namespace Ecommerce.Application.Feature.ProductFeature.Queries.Models;

public sealed class ProductGetByIdModel(string Id) : IRequest<ApplicationResponse<ProductGetByIdResult>>
{
    public string Id { get; set; } = Id;
}
