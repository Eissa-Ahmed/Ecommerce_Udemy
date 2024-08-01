namespace Ecommerce.Infrastucture.Configurations;

public sealed class SubCategoriesConfiguration : IEntityTypeConfiguration<SubCategory>
{
    public void Configure(EntityTypeBuilder<SubCategory> entity)
    {
        entity.ToTable(nameof(SubCategory));

        entity.HasKey(k => k.Name);

        entity
            .HasOne(o => o.Category)
            .WithMany(m => m.SubCategories)
            .HasForeignKey(i => i.CategoryName)
            .OnDelete(DeleteBehavior.Restrict);


        entity
            .HasOne(o => o.ParentSubcategory)
            .WithMany(m => m.SubCategorys)
            .HasForeignKey(i => i.ParentSubcategoryName)
            .OnDelete(DeleteBehavior.Restrict);

        entity
           .HasMany(m => m.Attributes)
           .WithOne(o => o.SubCategory)
           .HasForeignKey(i => i.SubCategoryName)
           .OnDelete(DeleteBehavior.Restrict);
    }
}
