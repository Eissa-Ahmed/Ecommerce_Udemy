namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttributes>
{
    public void Configure(EntityTypeBuilder<ProductAttributes> entity)
    {
        entity.ToTable(nameof(ProductAttributes));

        entity.HasKey(k => new { k.ProductId, k.AttributeName });

    }
}
