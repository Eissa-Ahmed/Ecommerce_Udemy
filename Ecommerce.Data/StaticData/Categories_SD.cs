namespace Ecommerce.Domain.StaticData;

/*public static class Categories_SD
{
    public static List<Category> GetCategories()
    {

        return new List<Category>
        {
                new Category {Name = "Men's Clothing", SubCategories = new List<Category> {
                    new Category {Name = "Casual Wear", SubCategories = new List<Category> {
                        new Category {Name = "T-Shirts"},
                        new Category {Name = "Shirts"},
                        new Category {Name = "Jeans"},
                        new Category {Name = "Trousers"},
                        new Category {Name = "Shorts"},
                    } },
                    new Category {Name = "Formal Wear"},
                    new Category {Name = "Watches"},
                    new Category {Name = "Sunglasses"},
                    new Category {Name = "Belts"},
                    new Category {Name = "Men's Footwear" , SubCategories = new List<Category> { 
                        //Men's Clothing > Footwear
                        new Category {Name = "Men's Casual Footwear"},
                        new Category {Name = "Men's Sports Shoes"},
                        new Category {Name = "Men's Formal Shoes"},
                        new Category {Name = "Men's Sandals & Slippers"},
                    }},
                    //Men's Clothing > Accessories
                    new Category {Name = "Men's Accessories", SubCategories = new List<Category> {
                        new Category {Name = "Men's Hats"},
                        new Category {Name = "Men's Scarves"},
                        new Category {Name = "Men's Gloves"},
                    }},
                }},

                new Category {Name = "Women's Clothing", SubCategories = new List<Category> {
                    new Category {Name = "Dresses"},
                    new Category {Name = "Blouses"},
                    new Category {Name = "Skirts"},
                    new Category {Name = "Lingerie"},
                    new Category {Name = "Jewelry"},
                    new Category {Name = "Bags"},
                    new Category {Name = "Women's Footwear" , SubCategories = new List<Category> { 
                        //Women's Clothing > Footwear
                        new Category {Name = "Women's Casual Footwear"},
                        new Category {Name = "Women's Sports Shoes"},
                        new Category {Name = "Women's Formal Shoes"},
                        new Category {Name = "Women's Sandals & Slippers"},
                    }},
                    //Women's Clothing > Accessories
                    new Category {Name = "Women's Accessories", SubCategories = new List<Category> {
                        new Category {Name = "Women's Hats"},
                        new Category {Name = "Women's Scarves"},
                        new Category {Name = "Women's Gloves"},
                    }},
                }},
        };
    }
}*/

public static class Categories_SD
{
    public static List<Category> GetCategories()
    {
        return new List<Category>
        {
            new Category
            {
                Name = "Men's Clothing",
                SubCategories = new List<Category>
                {
                    new Category
                    {
                        Name = "Top Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "T-Shirts" },
                            new Category { Name = "Shirts" },
                            new Category { Name = "Sweatshirts" },
                            new Category { Name = "Jackets" },
                            new Category { Name = "Hoodies" }
                        }
                    },
                    new Category
                    {
                        Name = "Bottom Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Jeans" },
                            new Category { Name = "Trousers" },
                            new Category { Name = "Shorts" },
                            new Category { Name = "Sweatpants" }
                        }
                    },
                    new Category
                    {
                        Name = "Outerwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Blazers" },
                            new Category { Name = "Coats" },
                            new Category { Name = "Raincoats" },
                            new Category { Name = "Suits" }
                        }
                    },
                    new Category
                    {
                        Name = "Sportswear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Running Wear" },
                            new Category { Name = "Gym Wear" },
                            new Category { Name = "Swimwear" }
                        }
                    },
                    new Category
                    {
                        Name = "Traditional Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Kurtas" },
                            new Category { Name = "Sherwani" },
                            new Category { Name = "Ethnic Jackets" }
                        }
                    },
                    new Category
                    {
                        Name = "Innerwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Underwear" },
                            new Category { Name = "Vests" },
                            new Category { Name = "Thermals" }
                        }
                    },
                    new Category
                    {
                        Name = "Footwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Casual Shoes" },
                            new Category { Name = "Formal Shoes" },
                            new Category { Name = "Sneakers" },
                            new Category { Name = "Boots" },
                            new Category { Name = "Sandals" }
                        }
                    },
                    new Category
                    {
                        Name = "Accessories",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Belts" },
                            new Category { Name = "Sunglasses" },
                            new Category { Name = "Watches" },
                            new Category { Name = "Hats" },
                            new Category { Name = "Scarves" }
                        }
                    }
                }
            },

            new Category
            {
                Name = "Women's Clothing",
                SubCategories = new List<Category>
                {
                    new Category
                    {
                        Name = "Top Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Tops" },
                            new Category { Name = "Blouses" },
                            new Category { Name = "Sweaters" },
                            new Category { Name = "Jackets" },
                            new Category { Name = "Hoodies" }
                        }
                    },
                    new Category
                    {
                        Name = "Bottom Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Jeans" },
                            new Category { Name = "Trousers" },
                            new Category { Name = "Skirts" },
                            new Category { Name = "Shorts" }
                        }
                    },
                    new Category
                    {
                        Name = "Outerwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Blazers" },
                            new Category { Name = "Coats" },
                            new Category { Name = "Raincoats" },
                            new Category { Name = "Suits" }
                        }
                    },
                    new Category
                    {
                        Name = "Sportswear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Running Wear" },
                            new Category { Name = "Gym Wear" },
                            new Category { Name = "Swimwear" }
                        }
                    },
                    new Category
                    {
                        Name = "Traditional Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Sarees" },
                            new Category { Name = "Lehenga" },
                            new Category { Name = "Ethnic Dresses" }
                        }
                    },
                    new Category
                    {
                        Name = "Innerwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Lingerie" },
                            new Category { Name = "Nightwear" },
                            new Category { Name = "Thermals" }
                        }
                    },
                    new Category
                    {
                        Name = "Footwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Casual Shoes" },
                            new Category { Name = "Formal Shoes" },
                            new Category { Name = "Sneakers" },
                            new Category { Name = "Boots" },
                            new Category { Name = "Sandals" },
                            new Category { Name = "Heels" }
                        }
                    },
                    new Category
                    {
                        Name = "Accessories",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Jewelry" },
                            new Category { Name = "Bags" },
                            new Category { Name = "Watches" },
                            new Category { Name = "Sunglasses" },
                            new Category { Name = "Scarves" }
                        }
                    }
                }
            },

            new Category
            {
                Name = "Kids' Clothing",
                SubCategories = new List<Category>
                {
                    new Category
                    {
                        Name = "Top Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "T-Shirts" },
                            new Category { Name = "Shirts" },
                            new Category { Name = "Sweatshirts" },
                            new Category { Name = "Jackets" },
                            new Category { Name = "Hoodies" }
                        }
                    },
                    new Category
                    {
                        Name = "Bottom Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Jeans" },
                            new Category { Name = "Trousers" },
                            new Category { Name = "Shorts" },
                            new Category { Name = "Sweatpants" }
                        }
                    },
                    new Category
                    {
                        Name = "Outerwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Coats" },
                            new Category { Name = "Jackets" },
                            new Category { Name = "Raincoats" }
                        }
                    },
                    new Category
                    {
                        Name = "Sportswear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Running Wear" },
                            new Category { Name = "Gym Wear" },
                            new Category { Name = "Swimwear" }
                        }
                    },
                    new Category
                    {
                        Name = "Traditional Wear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Ethnic Wear" },
                            new Category { Name = "Festive Wear" }
                        }
                    },
                    new Category
                    {
                        Name = "Innerwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Underwear" },
                            new Category { Name = "Vests" },
                            new Category { Name = "Thermals" }
                        }
                    },
                    new Category
                    {
                        Name = "Footwear",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "Casual Shoes" },
                            new Category { Name = "Sports Shoes" },
                            new Category { Name = "Boots" },
                            new Category { Name = "Sandals" }
                        }
                    },
                    new Category
                    {
                        Name = "Accessories",
                        SubCategories = new List<Category>
                        {
                            new Category { Name = "School Bags" },
                            new Category { Name = "Watches" },
                            new Category { Name = "Hats" },
                            new Category { Name = "Sunglasses" }
                        }
                    }
                }
            }
        };
    }
}

