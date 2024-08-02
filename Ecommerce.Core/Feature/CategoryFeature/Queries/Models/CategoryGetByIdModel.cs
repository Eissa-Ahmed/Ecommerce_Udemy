namespace Ecommerce.Application.Feature.CategoryFeature.Queries.Models;

public sealed class CategoryGetByIdModel(string Name) : IRequest<ApplicationResponse<CategoryGetByIdResult>>
{
    public string Name { get; set; } = Name;
}
