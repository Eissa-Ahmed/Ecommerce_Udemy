namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Models;

public sealed class CategoryUpdateNameModel(string Id, string Name) : IRequest<ApplicationResponse<CategoryUpdateResult>>
{
    public string Id { get; set; } = Id;
    public string Name { get; set; } = Name;

}
