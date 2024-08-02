namespace Ecommerce.Application.Feature.CategoryFeature.Queries.Models;

public sealed class CategoryGetAllModel(int count) : IRequest<ApplicationResponse<IReadOnlyList<CategoryGetAllResult>>>
{
    public int count { get; set; } = count;
}
