using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public sealed class Categories
{
    public Categories()
    {
        SubCategories = new List<SubCategories>();
    }
    [Key]
    public string Name { get; set; } = null!;
    public ICollection<SubCategories> SubCategories { get; set; }

}

