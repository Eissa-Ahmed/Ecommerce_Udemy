namespace Ecommerce.Application.Services.IServices.ICategoryContainer;

public interface ICategoryHelper
{
    public List<Category> GetSubCategoriesHierarchy(List<Category> category, string? ParentCategoryId);
    public Category GetCategory(Category category, List<Category> categories);

    public List<Category> GetCategories(List<Category> categories);
}
