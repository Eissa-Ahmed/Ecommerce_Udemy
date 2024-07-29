namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductConfiguration : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> entity)
    {
        entity.ToTable(nameof(Products));
        entity.HasKey(k => k.Id);

        entity.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);
        entity.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(500);
        entity.Property(p => p.MainImage)
            .IsRequired();
        entity.Property(p => p.StockQuantity)
            .HasAnnotation("MinValue", 1);
        entity.Property(p => p.Price)
            .IsRequired()
            .HasPrecision(8, 2)
            .HasAnnotation("MinValue", 0.01m);

        entity
            .HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(i => i.CategoryName)
            .OnDelete(DeleteBehavior.Restrict);

        entity
            .HasOne(p => p.SubCategory)
            .WithMany()
            .HasForeignKey(i => i.SubCategoryName)
            .OnDelete(DeleteBehavior.Restrict);

        entity
            .HasOne(p => p.Brand)
            .WithMany()
            .HasForeignKey(i => i.BrandName)
            .OnDelete(DeleteBehavior.Restrict);

        entity
            .HasMany(p => p.Images)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(p => p.ProductAttributes)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

public sealed class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttributes>
{
    public void Configure(EntityTypeBuilder<ProductAttributes> entity)
    {
        entity.ToTable(nameof(ProductAttributes));
        entity.HasKey(k => new { k.ProductId, k.AttributeName });


    }
}
public sealed class SubCategoriesConfiguration : IEntityTypeConfiguration<SubCategories>
{
    public void Configure(EntityTypeBuilder<SubCategories> entity)
    {
        entity.ToTable(nameof(ProductAttributes));
        entity
            .HasOne(o => o.ParentSubcategory)
            .WithMany()
            .HasForeignKey(i => i.ParentSubcategoryName)
            .OnDelete(DeleteBehavior.Restrict);


    }
}
