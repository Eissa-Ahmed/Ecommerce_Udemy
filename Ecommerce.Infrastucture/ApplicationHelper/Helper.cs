namespace Ecommerce.Infrastucture.ApplicationHelper;

public static class Helper
{
    private static List<Category> GetSubCategoriesHierarchy(List<Category> category, string? parentCateoryName)
    {
        return category.Where(i => i.ParentCategoryName == parentCateoryName)
            .Select(i => new Category
            {
                Name = i.Name,
                ParentCategoryName = i.ParentCategoryName,
                SubCategories = GetSubCategoriesHierarchy(category, i.Name)
            }).ToList();
    }
    public static Category GetCategory(Category category, List<Category> categories)
    {
        category.SubCategories = GetSubCategoriesHierarchy(categories, category.Name);
        return category;
    }
    public static List<Category> GetCategories(List<Category> categories)
    {
        return categories
            .Where(i => i.ParentCategoryName == null)
            .Select(i => new Category
            {
                Name = i.Name,
                ParentCategoryName = i.ParentCategoryName,
                SubCategories = GetSubCategoriesHierarchy(categories, i.Name)
            })
            .ToList();
    }
}
