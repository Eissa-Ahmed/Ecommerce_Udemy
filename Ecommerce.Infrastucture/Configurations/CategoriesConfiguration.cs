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

        entity.HasMany(m => m.Attributes)
              .WithMany(m => m.Categories)
              .UsingEntity<CategoryAttributes>(
                    i => i.HasOne(m => m.Attributes).WithMany(m => m.CategoryAttributes).HasForeignKey(i => i.AttributesId),
                    j => j.HasOne(m => m.Category).WithMany(m => m.CategoryAttributes).HasForeignKey(i => i.CategoryId)
              );

    }
}
