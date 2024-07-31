namespace Ecommerce.Infrastucture.Configurations;

public sealed class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
{
    public void Configure(EntityTypeBuilder<Categories> entity)
    {
        entity.ToTable(nameof(Categories));

        entity.HasKey(k => k.Name);

        entity
            .HasMany(o => o.SubCategories)
            .WithOne()
            .HasForeignKey(i => i.CategoryName)
            .OnDelete(DeleteBehavior.Restrict);


        entity
           .HasMany(o => o.Products)
           .WithOne()
           .HasForeignKey(i => i.CategoryName)
           .OnDelete(DeleteBehavior.Restrict);

    }
}
