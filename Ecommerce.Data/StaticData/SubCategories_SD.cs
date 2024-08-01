namespace Ecommerce.Domain.StaticData;

public static class SubCategories_SD
{
    public static List<SubCategory> GetSubCategories()
    {
        return new List<SubCategory>
        {
            //-------------------------------- Electronics ----------------------------------------

            //Mobile Phones
            new SubCategory {Name = "Mobile Phones", CategoryName = "Electronics"},
            new SubCategory {Name = "Smartphones", CategoryName = "Electronics", ParentSubcategoryName = "Mobile phones"},
            new SubCategory {Name = "Feature Phones", CategoryName = "Electronics", ParentSubcategoryName = "Mobile phones"},
            new SubCategory {Name = "Phone Accessories", CategoryName = "Electronics", ParentSubcategoryName = "Mobile phones"},
            new SubCategory {Name = "Cases & Covers", CategoryName = "Electronics", ParentSubcategoryName = "Mobile phones"},
            new SubCategory {Name = "Earphones & Headphones", CategoryName = "Electronics", ParentSubcategoryName = "Mobile phones"},

            //Tablets
            new SubCategory {Name = "Tablets", CategoryName = "Electronics"},
            new SubCategory {Name = "General Tablets", CategoryName = "Electronics", ParentSubcategoryName = "Tablets"},
            new SubCategory {Name = "Educational Tablets", CategoryName = "Electronics", ParentSubcategoryName = "Tablets"},
            new SubCategory {Name = "Tablet Accessories", CategoryName = "Electronics", ParentSubcategoryName = "Tablets"},

            //Computers & Laptops
            new SubCategory {Name = "Computers & Laptops", CategoryName = "Electronics"},
            new SubCategory {Name = "Laptops", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Desktop Computers", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Components & Parts", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Processors", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Graphics Cards", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Memory", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Computer Accessories", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Monitors", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Keyboards & Mice", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},
            new SubCategory {Name = "Printers & Scanners", CategoryName = "Electronics", ParentSubcategoryName = "Computers & Laptops"},

            //Televisions
            new SubCategory {Name = "Televisions", CategoryName = "Electronics"},
            new SubCategory {Name = "Smart TVs", CategoryName = "Electronics", ParentSubcategoryName = "Televisions"},
            new SubCategory {Name = "Standard TVs", CategoryName = "Electronics", ParentSubcategoryName = "Televisions"},
            new SubCategory {Name = "TV Accessories", CategoryName = "Electronics", ParentSubcategoryName = "Televisions"},

            //Cameras
            new SubCategory {Name = "Cameras", CategoryName = "Electronics"},
            new SubCategory {Name = "Digital Cameras", CategoryName = "Electronics", ParentSubcategoryName = "Cameras"},
            new SubCategory {Name = "DSLR & Mirrorless Cameras", CategoryName = "Electronics", ParentSubcategoryName = "Cameras"},
            new SubCategory {Name = "Video Cameras", CategoryName = "Electronics", ParentSubcategoryName = "Cameras"},
            new SubCategory {Name = "Camera Accessories", CategoryName = "Electronics", ParentSubcategoryName = "Cameras"},

            //-------------------------------- Fashion ----------------------------------------

            /*//Men's Clothing
            new SubCategory {Name = "Men's Clothing", CategoryName = "Fashion"},
            new SubCategory {Name = "Casual Wear", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Formal Wear", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Sportswear", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Men's Accessories", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Watches", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Sunglasses", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Belts", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            //Men's Clothing > Footwear
            new SubCategory {Name = "Men's Footwear", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Men's Casual Footwear", CategoryName = "Fashion", ParentSubcategoryName = "Men's Footwear"},
            new SubCategory {Name = "Men's Sports Shoes", CategoryName = "Fashion", ParentSubcategoryName = "Men's Footwear"},
            new SubCategory {Name = "Men's Formal Shoes", CategoryName = "Fashion", ParentSubcategoryName = "Men's Footwear"},
            new SubCategory {Name = "Men's Sandals & Slippers", CategoryName = "Fashion", ParentSubcategoryName = "Men's Footwear"},
            //Men's Clothing > Accessories
            new SubCategory {Name = "Men's Accessories", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Men's Hats", CategoryName = "Fashion", ParentSubcategoryName = "Men's Accessories"},
            new SubCategory {Name = "Men's Scarves", CategoryName = "Fashion", ParentSubcategoryName = "Men's Accessories"},
            new SubCategory {Name = "Men's Gloves", CategoryName = "Fashion", ParentSubcategoryName = "Men's Accessories"},

            //Women's Clothing
            new SubCategory {Name = "Women's Clothing", CategoryName = "Fashion"},
            new SubCategory {Name = "Dresses", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            new SubCategory {Name = "Blouses", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            new SubCategory {Name = "Skirts", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            new SubCategory {Name = "Lingerie", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            new SubCategory {Name = "Women's Accessories", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            new SubCategory {Name = "Jewelry", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            new SubCategory {Name = "Bags", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            //Women's Clothing > Footwear
            new SubCategory {Name = "Women's Footwear", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            new SubCategory {Name = "Women's Casual Footwear", CategoryName = "Fashion", ParentSubcategoryName = "Women's Footwear"},
            new SubCategory {Name = "Women's Sports Shoes", CategoryName = "Fashion", ParentSubcategoryName = "Women's Footwear"},
            new SubCategory {Name = "Women's Formal Shoes", CategoryName = "Fashion", ParentSubcategoryName = "Men's Footwear"},
            new SubCategory {Name = "Women's Sandals & Slippers", CategoryName = "Fashion", ParentSubcategoryName = "Men's Footwear"},
            //Women's Clothing > Accessories
            new SubCategory {Name = "Women's Accessories", CategoryName = "Fashion", ParentSubcategoryName = "Women's Clothing"},
            new SubCategory {Name = "Women's Hats", CategoryName = "Fashion", ParentSubcategoryName = "Women's Accessories"},
            new SubCategory {Name = "Women's Scarves", CategoryName = "Fashion", ParentSubcategoryName = "Women's Accessories"},
            new SubCategory {Name = "Women's Gloves", CategoryName = "Fashion", ParentSubcategoryName = "Women's Accessories"},*/



            //-------------------------------- Home & Kitchen ----------------------------------------
            //-------------------------------- Books & Music ----------------------------------------
            //-------------------------------- Beauty & Personal Care ----------------------------------------
            //-------------------------------- Sports & Fitness ----------------------------------------
            //-------------------------------- Toys & Kids ----------------------------------------
            //-------------------------------- Food & Groceries ----------------------------------------
            //-------------------------------- Health & Wellness ----------------------------------------
            //-------------------------------- Industrial Products ----------------------------------------
        };
    }
}
