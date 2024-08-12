namespace Ecommerce.Infrastucture.ApplicationHelper;

public static class Helper
{
    public static List<Category> GetSubCategoriesHierarchy(List<Category> category, string? ParentCategoryId)
    {
        return category.Where(i => i.ParentCategoryId == ParentCategoryId)
            .Select(i => new Category
            {
                Id = i.Id,
                Name = i.Name,
                ParentCategoryId = i.ParentCategoryId,
                Products = i.Products,
                ParentCategory = i.ParentCategory,
                SubCategories = GetSubCategoriesHierarchy(category, i.Id)
            }).ToList();
    }
    public static Category GetCategory(Category category, List<Category> categories)
    {
        Category result = category;
        result.SubCategories = GetSubCategoriesHierarchy(categories, category.Id);
        return result;
    }
    public static List<Category> GetCategories(List<Category> categories)
    {
        return categories
            .Where(i => i.ParentCategoryId == null)
            .Select(i => new Category
            {
                Id = i.Id,
                Name = i.Name,
                ParentCategoryId = i.ParentCategoryId,
                Products = i.Products,
                ParentCategory = i.ParentCategory,
                SubCategories = GetSubCategoriesHierarchy(categories, i.Id)
            })
            .ToList();
    }
}
