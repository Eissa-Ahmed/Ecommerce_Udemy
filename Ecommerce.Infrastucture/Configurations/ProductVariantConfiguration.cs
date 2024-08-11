namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
{
    public void Configure(EntityTypeBuilder<ProductVariant> entity)
    {
        entity.ToTable(nameof(ProductVariant));

        entity.HasKey(k => k.Id);

        entity.Property(p => p.Color)
            .HasMaxLength(7);

        entity.Property(p => p.Material)
            .HasMaxLength(50);

        entity.Property(p => p.Price)
            .HasPrecision(8, 2)
            .IsRequired();

        entity.Property(p => p.StockQuantity)
            .HasAnnotation("MinValue", 1)
            .IsRequired();

        entity.Ignore(i => i.SKU);

        entity.Property(p => p.Size)
            .HasConversion(
                v => v.ToString(),
                v => (ProductSize)Enum.Parse(typeof(ProductSize), v));

    }
}