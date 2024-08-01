namespace Ecommerce.Domain.StaticData;

public static class Categories_SD
{
    public static List<Category> GetCategories()
    {
        return new List<Category>
        {
            new Category {Name = "Electronics"},
            new Category {Name = "Fashion"},
            new Category {Name = "Home & Kitchen"},
            new Category {Name = "Books & Music"},
            new Category {Name = "Beauty & Personal Care"},
            new Category {Name = "Sports & Fitness"},
            new Category {Name = "Toys & Kids"},
            new Category {Name = "Food & Groceries"},
            new Category {Name = "Health & Wellness"},
            new Category {Name = "Industrial Products"},
        };
    }
}
