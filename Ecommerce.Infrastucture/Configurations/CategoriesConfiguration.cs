namespace Ecommerce.Infrastucture.Configurations;

public sealed class CategoriesConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> entity)
    {
        entity.ToTable(nameof(Category));

        entity.HasKey(k => k.Id);
        entity.HasIndex(i => i.Name).IsUnique();


        entity
            .HasMany(o => o.SubCategories)
            .WithOne(o => o.ParentCategory)
            .HasForeignKey(i => i.ParentCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        entity
           .HasMany(o => o.Products)
           .WithOne(o => o.Category)
           .HasForeignKey(i => i.CategoryId)
           .OnDelete(DeleteBehavior.Restrict);
    }
}
