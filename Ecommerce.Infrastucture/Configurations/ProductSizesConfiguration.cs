namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductSizesConfiguration : IEntityTypeConfiguration<ProductSizes>
{
    public void Configure(EntityTypeBuilder<ProductSizes> entity)
    {
        entity.ToTable(nameof(ProductSizes));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Size)
            .IsRequired();

        entity.Property(i => i.Count)
            .IsRequired();
    }
}
