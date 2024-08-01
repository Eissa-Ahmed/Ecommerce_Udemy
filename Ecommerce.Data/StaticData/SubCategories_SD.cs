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

            //Men's Clothing
            new SubCategory {Name = "Men's Clothing", CategoryName = "Fashion"},
            new SubCategory {Name = "Casual Wear", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
            new SubCategory {Name = "Formal Wear", CategoryName = "Fashion", ParentSubcategoryName = "Men's Clothing"},
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
            new SubCategory {Name = "Women's Gloves", CategoryName = "Fashion", ParentSubcategoryName = "Women's Accessories"},


            //-------------------------------- Home & Kitchen ----------------------------------------
            //Furniture
            new SubCategory {Name = "Furniture", CategoryName = "Home & Kitchen"},
            new SubCategory {Name = "Living Room Furniture", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Furniture"},
            new SubCategory {Name = "Bedroom Furniture", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Furniture"},
            new SubCategory {Name = "Kitchen Furniture", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Furniture"},
            new SubCategory {Name = "Outdoor Furniture", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Furniture"},

            //Home Appliances
            new SubCategory {Name = "Home Appliances", CategoryName = "Home & Kitchen"},
            new SubCategory {Name = "Refrigerators", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Home Appliances"},
            new SubCategory {Name = "Ovens & Stoves", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Home Appliances"},
            new SubCategory {Name = "Washing Machines", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Home Appliances"},
            new SubCategory {Name = "Vacuum Cleaners", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Home Appliances"},


            //Kitchen Tools & Gadgets
            new SubCategory {Name = "Kitchen Tools & Gadgets", CategoryName = "Home & Kitchen"},
            new SubCategory {Name = "Cooking Utensils", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Kitchen Tools & Gadgets"},
            new SubCategory {Name = "Small Kitchen Appliances", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Kitchen Tools & Gadgets"},
            new SubCategory {Name = "Blenders", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Kitchen Tools & Gadgets"},
            new SubCategory {Name = "Coffee Makers", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Kitchen Tools & Gadgets"},


            //Home Decor
            new SubCategory {Name = "Home Decor", CategoryName = "Home & Kitchen"},
            new SubCategory {Name = "Wall Decor", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Home Decor"},
            new SubCategory {Name = "Lighting", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Home Decor"},
            new SubCategory {Name = "Textiles & Rugs", CategoryName = "Home & Kitchen", ParentSubcategoryName = "Home Decor"},


            //-------------------------------- Books & Music ----------------------------------------
            new SubCategory {Name = "Books", CategoryName = "Books & Music"},
            new SubCategory {Name = "Fiction", CategoryName = "Books & Music"},
            new SubCategory {Name = "Non-Fiction", CategoryName = "Books & Music"},
            new SubCategory {Name = "Educational", CategoryName = "Books & Music"},
            new SubCategory {Name = "Children's Books", CategoryName = "Books & Music"},

            //Musical Instruments
            new SubCategory {Name = "Musical Instruments", CategoryName = "Books & Music"},
            new SubCategory {Name = "String Instruments", CategoryName = "Books & Music", ParentSubcategoryName = "Musical Instruments"},
            new SubCategory {Name = "Brass Instruments", CategoryName = "Books & Music", ParentSubcategoryName = "Musical Instruments"},
            new SubCategory {Name = "Percussion Instruments", CategoryName = "Books & Music", ParentSubcategoryName = "Musical Instruments"},

            //Music
            new SubCategory {Name = "Music", CategoryName = "Books & Music"},
            new SubCategory {Name = "CDs", CategoryName = "Books & Music", ParentSubcategoryName = "Music"},
            new SubCategory {Name = "Vinyl", CategoryName = "Books & Music", ParentSubcategoryName = "Music"},
            new SubCategory {Name = "Digital Music Equipment", CategoryName = "Books & Music", ParentSubcategoryName = "Music"},


            //-------------------------------- Beauty & Personal Care ----------------------------------------
            //Cosmetics
            new SubCategory{Name = "Cosmetics", CategoryName = "Beauty & Personal Care"},
            new SubCategory{Name = "Face Makeup", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Cosmetics"},
            new SubCategory{Name = "Eye Makeup", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Cosmetics"},
            new SubCategory{Name = "Lip Makeup", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Cosmetics"},

            //Skin Care
            new SubCategory{Name = "Skin Care", CategoryName = "Beauty & Personal Care"},
            new SubCategory{Name = "Cleansers", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Skin Care"},
            new SubCategory{Name = "Moisturizers", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Skin Care"},
            new SubCategory{Name = "Anti-Aging Products", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Skin Care"},

            //Perfumes
            new SubCategory{Name = "Perfumes", CategoryName = "Beauty & Personal Care"},
            new SubCategory{Name = "Women's Perfumes", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Perfumes"},
            new SubCategory{Name = "Men's Perfumes", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Perfumes"},


            //Hair Care
            new SubCategory{Name = "Hair Care", CategoryName = "Beauty & Personal Care"},
            new SubCategory{Name = "Shampoos & Conditioners", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Hair Care"},
            new SubCategory{Name = "Styling Products", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Hair Care"},
            new SubCategory{Name = "Hair Tools", CategoryName = "Beauty & Personal Care", ParentSubcategoryName = "Hair Care"},



            //-------------------------------- Sports & Fitness ----------------------------------------
            //Fitness Equipment
            new SubCategory{Name = "Fitness Equipment", CategoryName = "Sports & Fitness"},
            new SubCategory{Name = "Weights & Dumbbells", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Fitness Equipment"},
            new SubCategory{Name = "Treadmills", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Fitness Equipment"},
            new SubCategory{Name = "Exercise Machines", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Fitness Equipment"},


            //Sportswear
            new SubCategory{Name = "Sportswear", CategoryName = "Sports & Fitness"},
            new SubCategory{Name = "Running Wear", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Sportswear"},
            new SubCategory{Name = "Gym Wear", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Sportswear"},
            new SubCategory{Name = "Swimwear", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Sportswear"},


            //Sports Gear
            new SubCategory{Name = "Sports Gear", CategoryName = "Sports & Fitness"},
            new SubCategory{Name = "Football Gear", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Sports Gear"},
            new SubCategory{Name = "Tennis Gear", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Sports Gear"},
            new SubCategory{Name = "Basketball Gear", CategoryName = "Sports & Fitness", ParentSubcategoryName = "Sports Gear"},



            //-------------------------------- Toys & Kids ----------------------------------------
            //Toys
            new SubCategory{Name = "Toys", CategoryName = "Toys & Kids"},
            new SubCategory{Name = "Educational Toys", CategoryName = "Toys & Kids", ParentSubcategoryName = "Toys"},
            new SubCategory{Name = "Electronic Toys", CategoryName = "Toys & Kids", ParentSubcategoryName = "Toys"},
            new SubCategory{Name = "Outdoor Toys", CategoryName = "Toys & Kids", ParentSubcategoryName = "Toys"},


            //Kids' Clothing
            new SubCategory{Name = "Kids' Clothing", CategoryName = "Toys & Kids"},
            new SubCategory{Name = "Infant Clothing", CategoryName = "Toys & Kids", ParentSubcategoryName = "Kids' Clothing"},
            new SubCategory{Name = "Girls' Clothing", CategoryName = "Toys & Kids", ParentSubcategoryName = "Kids' Clothing"},
            new SubCategory{Name = "Boys' Clothing", CategoryName = "Toys & Kids", ParentSubcategoryName = "Kids' Clothing"},


            //Baby Products
            new SubCategory{Name = "Baby Products", CategoryName = "Toys & Kids"},
            new SubCategory{Name = "Diapers", CategoryName = "Toys & Kids", ParentSubcategoryName = "Baby Products"},
            new SubCategory{Name = "Strollers", CategoryName = "Toys & Kids", ParentSubcategoryName = "Baby Products"},
            new SubCategory{Name = "Car Seats", CategoryName = "Toys & Kids", ParentSubcategoryName = "Baby Products"},

            //-------------------------------- Food & Groceries ----------------------------------------
            new SubCategory{Name = "Fresh Foods", CategoryName = "Food & Groceries"},
            new SubCategory{Name = "Canned & Packaged Foods", CategoryName = "Food & Groceries"},


            //-------------------------------- Health & Wellness ----------------------------------------
            new SubCategory{Name = "Supplements", CategoryName = "Health & Wellness"},
            new SubCategory{Name = "Medical Devices", CategoryName = "Health & Wellness"},


            //-------------------------------- Industrial Products ----------------------------------------
            new SubCategory{Name = "Industrial Equipment", CategoryName = "Industrial Products"},
            new SubCategory{Name = "Raw Materials", CategoryName = "Industrial Products"},

        };
    }
}
