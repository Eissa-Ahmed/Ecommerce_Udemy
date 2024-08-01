namespace Ecommerce.Infrastucture.Configurations;

public sealed class CategoriesConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> entity)
    {
        entity.ToTable(nameof(Category));

        entity.HasKey(k => k.Name);

        entity
            .HasMany(o => o.SubCategories)
            .WithOne(o => o.Category)
            .HasForeignKey(i => i.CategoryName)
            .OnDelete(DeleteBehavior.Restrict);


        entity
           .HasMany(o => o.Products)
           .WithOne(o => o.Category)
           .HasForeignKey(i => i.CategoryName)
           .OnDelete(DeleteBehavior.Restrict);

    }
}
