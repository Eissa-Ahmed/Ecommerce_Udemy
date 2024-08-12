namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Models;

public sealed class CategoryDeleteModel(string Id) : IRequest<ApplicationResponse<string>>
{
    public string Id { get; set; } = Id;
}
