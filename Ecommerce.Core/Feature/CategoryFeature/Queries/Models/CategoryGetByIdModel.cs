namespace Ecommerce.Application.Feature.CategoryFeature.Queries.Models;

public sealed class CategoryGetByIdModel(string Id) : IRequest<ApplicationResponse<CategoryGetByIdResult>>
{
    public string Id { get; set; } = Id;
}
