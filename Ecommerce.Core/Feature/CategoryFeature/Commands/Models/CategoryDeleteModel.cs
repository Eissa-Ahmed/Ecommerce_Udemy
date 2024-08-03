namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Models;

public sealed class CategoryDeleteModel(string Name) : IRequest<ApplicationResponse<string>>
{
    public string Name { get; set; } = Name;
}
