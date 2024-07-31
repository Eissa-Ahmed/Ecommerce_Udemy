namespace Ecommerce.Infrastucture.Configurations;

public sealed class SubCategoriesConfiguration : IEntityTypeConfiguration<SubCategories>
{
    public void Configure(EntityTypeBuilder<SubCategories> entity)
    {
        entity.ToTable(nameof(SubCategories));

        entity.HasKey(k => k.Name);

        entity
            .HasOne(o => o.Category)
            .WithMany()
            .HasForeignKey(i => i.CategoryName)
            .OnDelete(DeleteBehavior.Restrict);


        entity
            .HasOne(o => o.ParentSubcategory)
            .WithMany(m => m.SubCategorys)
            .HasForeignKey(i => i.ParentSubcategoryName)
            .OnDelete(DeleteBehavior.Restrict);

        entity
           .HasMany(m => m.Attributes)
           .WithOne()
           .HasForeignKey(i => i.SubCategoryName)
           .OnDelete(DeleteBehavior.Restrict);
    }
}
