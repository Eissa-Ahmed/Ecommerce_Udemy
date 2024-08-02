namespace Ecommerce.Application.Commands.Models;

public sealed class CategoryCreateModel
{
    public CategoryCreateModel()
    {
        SubCategories = new List<string>();
    }
    public string CategoryName { get; set; } = null!;
    public IEnumerable<string> SubCategories { get; set; }
}
