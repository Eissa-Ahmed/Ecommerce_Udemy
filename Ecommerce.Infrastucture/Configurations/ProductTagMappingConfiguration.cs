namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductTagMappingConfiguration : IEntityTypeConfiguration<ProductTagMapping>
{
    public void Configure(EntityTypeBuilder<ProductTagMapping> entity)
    {
        entity.ToTable(nameof(ProductTagMapping));

        entity.HasKey(k => k.Id);

    }
}
