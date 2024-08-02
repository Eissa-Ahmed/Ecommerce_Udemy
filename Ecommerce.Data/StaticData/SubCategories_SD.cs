/*namespace Ecommerce.Domain.StaticData;

public static class SubCategories_SD
{
    public static List<Category> GetSubCategories()
    {
        return new List<Category>
        {
            //-------------------------------- Electronics ----------------------------------------
            //Mobile Phones
            new Category {Name = "Mobile Phones", ParentCategoryName = "Electronics"},
            new Category {Name = "Smartphones",  ParentCategoryName = "Mobile phones"},
            new Category {Name = "Feature Phones",  ParentCategoryName = "Mobile phones"},
            new Category {Name = "Phone Accessories",  ParentCategoryName = "Mobile phones"},
            new Category {Name = "Cases & Covers",  ParentCategoryName = "Mobile phones"},
            new Category {Name = "Earphones & Headphones",  ParentCategoryName = "Mobile phones"},

            //Tablets
            new Category {Name = "Tablets", ParentCategoryName = "Electronics"},
            new Category {Name = "General Tablets", ParentCategoryName = "Electronics", ParentCategoryName = "Tablets"},
            new Category {Name = "Educational Tablets", ParentCategoryName = "Electronics", ParentCategoryName = "Tablets"},
            new Category {Name = "Tablet Accessories", ParentCategoryName = "Electronics", ParentCategoryName = "Tablets"},

            //Computers & Laptops
            new Category {Name = "Computers & Laptops", ParentCategoryName = "Electronics"},
            new Category {Name = "Laptops", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Desktop Computers", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Components & Parts", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Processors", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Graphics Cards", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Memory", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Computer Accessories", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Monitors", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Keyboards & Mice", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},
            new Category {Name = "Printers & Scanners", ParentCategoryName = "Electronics", ParentCategoryName = "Computers & Laptops"},

            //Televisions
            new Category {Name = "Televisions", ParentCategoryName = "Electronics"},
            new Category {Name = "Smart TVs", ParentCategoryName = "Electronics", ParentCategoryName = "Televisions"},
            new Category {Name = "Standard TVs", ParentCategoryName = "Electronics", ParentCategoryName = "Televisions"},
            new Category {Name = "TV Accessories", ParentCategoryName = "Electronics", ParentCategoryName = "Televisions"},

            //Cameras
            new Category {Name = "Cameras", ParentCategoryName = "Electronics"},
            new Category {Name = "Digital Cameras", ParentCategoryName = "Electronics", ParentCategoryName = "Cameras"},
            new Category {Name = "DSLR & Mirrorless Cameras", ParentCategoryName = "Electronics", ParentCategoryName = "Cameras"},
            new Category {Name = "Video Cameras", ParentCategoryName = "Electronics", ParentCategoryName = "Cameras"},
            new Category {Name = "Camera Accessories", ParentCategoryName = "Electronics", ParentCategoryName = "Cameras"},

            //-------------------------------- Fashion ----------------------------------------

            //Men's Clothing
            new Category {Name = "Men's Clothing", ParentCategoryName = "Fashion"},
            new Category {Name = "Casual Wear", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Clothing"},
            new Category {Name = "Formal Wear", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Clothing"},
            new Category {Name = "Watches", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Clothing"},
            new Category {Name = "Sunglasses", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Clothing"},
            new Category {Name = "Belts", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Clothing"},
            //Men's Clothing > Footwear
            new Category {Name = "Men's Footwear", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Clothing"},
            new Category {Name = "Men's Casual Footwear", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Footwear"},
            new Category {Name = "Men's Sports Shoes", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Footwear"},
            new Category {Name = "Men's Formal Shoes", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Footwear"},
            new Category {Name = "Men's Sandals & Slippers", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Footwear"},
            //Men's Clothing > Accessories
            new Category {Name = "Men's Accessories", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Clothing"},
            new Category {Name = "Men's Hats", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Accessories"},
            new Category {Name = "Men's Scarves", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Accessories"},
            new Category {Name = "Men's Gloves", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Accessories"},

            //Women's Clothing
            new Category {Name = "Women's Clothing", ParentCategoryName = "Fashion"},
            new Category {Name = "Dresses", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Clothing"},
            new Category {Name = "Blouses", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Clothing"},
            new Category {Name = "Skirts", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Clothing"},
            new Category {Name = "Lingerie", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Clothing"},
            new Category {Name = "Jewelry", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Clothing"},
            new Category {Name = "Bags", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Clothing"},
            //Women's Clothing > Footwear
            new Category {Name = "Women's Footwear", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Clothing"},
            new Category {Name = "Women's Casual Footwear", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Footwear"},
            new Category {Name = "Women's Sports Shoes", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Footwear"},
            new Category {Name = "Women's Formal Shoes", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Footwear"},
            new Category {Name = "Women's Sandals & Slippers", ParentCategoryName = "Fashion", ParentCategoryName = "Men's Footwear"},
            //Women's Clothing > Accessories
            new Category {Name = "Women's Accessories", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Clothing"},
            new Category {Name = "Women's Hats", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Accessories"},
            new Category {Name = "Women's Scarves", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Accessories"},
            new Category {Name = "Women's Gloves", ParentCategoryName = "Fashion", ParentCategoryName = "Women's Accessories"},


            //-------------------------------- Home & Kitchen ----------------------------------------
            //Furniture
            new Category {Name = "Furniture", ParentCategoryName = "Home & Kitchen"},
            new Category {Name = "Living Room Furniture", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Furniture"},
            new Category {Name = "Bedroom Furniture", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Furniture"},
            new Category {Name = "Kitchen Furniture", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Furniture"},
            new Category {Name = "Outdoor Furniture", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Furniture"},

            //Home Appliances
            new Category {Name = "Home Appliances", ParentCategoryName = "Home & Kitchen"},
            new Category {Name = "Refrigerators", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Home Appliances"},
            new Category {Name = "Ovens & Stoves", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Home Appliances"},
            new Category {Name = "Washing Machines", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Home Appliances"},
            new Category {Name = "Vacuum Cleaners", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Home Appliances"},


            //Kitchen Tools & Gadgets
            new Category {Name = "Kitchen Tools & Gadgets", ParentCategoryName = "Home & Kitchen"},
            new Category {Name = "Cooking Utensils", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Kitchen Tools & Gadgets"},
            new Category {Name = "Small Kitchen Appliances", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Kitchen Tools & Gadgets"},
            new Category {Name = "Blenders", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Kitchen Tools & Gadgets"},
            new Category {Name = "Coffee Makers", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Kitchen Tools & Gadgets"},


            //Home Decor
            new Category {Name = "Home Decor", ParentCategoryName = "Home & Kitchen"},
            new Category {Name = "Wall Decor", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Home Decor"},
            new Category {Name = "Lighting", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Home Decor"},
            new Category {Name = "Textiles & Rugs", ParentCategoryName = "Home & Kitchen", ParentCategoryName = "Home Decor"},


            //-------------------------------- Books & Music ----------------------------------------
            new Category {Name = "Books", ParentCategoryName = "Books & Music"},
            new Category {Name = "Fiction", ParentCategoryName = "Books & Music"},
            new Category {Name = "Non-Fiction", ParentCategoryName = "Books & Music"},
            new Category {Name = "Educational", ParentCategoryName = "Books & Music"},
            new Category {Name = "Children's Books", ParentCategoryName = "Books & Music"},

            //Musical Instruments
            new Category {Name = "Musical Instruments", ParentCategoryName = "Books & Music"},
            new Category {Name = "String Instruments", ParentCategoryName = "Books & Music", ParentCategoryName = "Musical Instruments"},
            new Category {Name = "Brass Instruments", ParentCategoryName = "Books & Music", ParentCategoryName = "Musical Instruments"},
            new Category {Name = "Percussion Instruments", ParentCategoryName = "Books & Music", ParentCategoryName = "Musical Instruments"},

            //Music
            new Category {Name = "Music", ParentCategoryName = "Books & Music"},
            new Category {Name = "CDs", ParentCategoryName = "Books & Music", ParentCategoryName = "Music"},
            new Category {Name = "Vinyl", ParentCategoryName = "Books & Music", ParentCategoryName = "Music"},
            new Category {Name = "Digital Music Equipment", ParentCategoryName = "Books & Music", ParentCategoryName = "Music"},


            //-------------------------------- Beauty & Personal Care ----------------------------------------
            //Cosmetics
            new Category{Name = "Cosmetics", ParentCategoryName = "Beauty & Personal Care"},
            new Category{Name = "Face Makeup", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Cosmetics"},
            new Category{Name = "Eye Makeup", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Cosmetics"},
            new Category{Name = "Lip Makeup", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Cosmetics"},

            //Skin Care
            new Category{Name = "Skin Care", ParentCategoryName = "Beauty & Personal Care"},
            new Category{Name = "Cleansers", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Skin Care"},
            new Category{Name = "Moisturizers", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Skin Care"},
            new Category{Name = "Anti-Aging Products", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Skin Care"},

            //Perfumes
            new Category{Name = "Perfumes", ParentCategoryName = "Beauty & Personal Care"},
            new Category{Name = "Women's Perfumes", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Perfumes"},
            new Category{Name = "Men's Perfumes", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Perfumes"},


            //Hair Care
            new Category{Name = "Hair Care", ParentCategoryName = "Beauty & Personal Care"},
            new Category{Name = "Shampoos & Conditioners", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Hair Care"},
            new Category{Name = "Styling Products", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Hair Care"},
            new Category{Name = "Hair Tools", ParentCategoryName = "Beauty & Personal Care", ParentCategoryName = "Hair Care"},



            //-------------------------------- Sports & Fitness ----------------------------------------
            //Fitness Equipment
            new Category{Name = "Fitness Equipment", ParentCategoryName = "Sports & Fitness"},
            new Category{Name = "Weights & Dumbbells", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Fitness Equipment"},
            new Category{Name = "Treadmills", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Fitness Equipment"},
            new Category{Name = "Exercise Machines", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Fitness Equipment"},


            //Sportswear
            new Category{Name = "Sportswear", ParentCategoryName = "Sports & Fitness"},
            new Category{Name = "Running Wear", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Sportswear"},
            new Category{Name = "Gym Wear", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Sportswear"},
            new Category{Name = "Swimwear", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Sportswear"},


            //Sports Gear
            new Category{Name = "Sports Gear", ParentCategoryName = "Sports & Fitness"},
            new Category{Name = "Football Gear", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Sports Gear"},
            new Category{Name = "Tennis Gear", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Sports Gear"},
            new Category{Name = "Basketball Gear", ParentCategoryName = "Sports & Fitness", ParentCategoryName = "Sports Gear"},



            //-------------------------------- Toys & Kids ----------------------------------------
            //Toys
            new Category{Name = "Toys", ParentCategoryName = "Toys & Kids"},
            new Category{Name = "Educational Toys", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Toys"},
            new Category{Name = "Electronic Toys", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Toys"},
            new Category{Name = "Outdoor Toys", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Toys"},


            //Kids' Clothing
            new Category{Name = "Kids' Clothing", ParentCategoryName = "Toys & Kids"},
            new Category{Name = "Infant Clothing", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Kids' Clothing"},
            new Category{Name = "Girls' Clothing", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Kids' Clothing"},
            new Category{Name = "Boys' Clothing", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Kids' Clothing"},


            //Baby Products
            new Category{Name = "Baby Products", ParentCategoryName = "Toys & Kids"},
            new Category{Name = "Diapers", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Baby Products"},
            new Category{Name = "Strollers", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Baby Products"},
            new Category{Name = "Car Seats", ParentCategoryName = "Toys & Kids", ParentCategoryName = "Baby Products"},

            //-------------------------------- Food & Groceries ----------------------------------------
            new Category{Name = "Fresh Foods", ParentCategoryName = "Food & Groceries"},
            new Category{Name = "Canned & Packaged Foods", ParentCategoryName = "Food & Groceries"},


            //-------------------------------- Health & Wellness ----------------------------------------
            new Category{Name = "Supplements", ParentCategoryName = "Health & Wellness"},
            new Category{Name = "Medical Devices", ParentCategoryName = "Health & Wellness"},


            //-------------------------------- Industrial Products ----------------------------------------
            new Category{Name = "Industrial Equipment", ParentCategoryName = "Industrial Products"},
            new Category{Name = "Raw Materials", ParentCategoryName = "Industrial Products"},

        };
    }
}
*/