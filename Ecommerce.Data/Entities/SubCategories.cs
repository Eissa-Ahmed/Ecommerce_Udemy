using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities;

public sealed class SubCategories
{
    public SubCategories()
    {
        Attributes = new List<Attributes>();
    }
    [Key]
    public string Name { get; set; } = null!;
    [ForeignKey("ParentSubcategory")]
    public string ParentSubcategoryName { get; set; } = null!;
    public ICollection<Attributes> Attributes { get; set; }
    public SubCategories ParentSubcategory { get; set; } = null!;
    public ICollection<SubCategories> SubCategory { get; set; }

}

