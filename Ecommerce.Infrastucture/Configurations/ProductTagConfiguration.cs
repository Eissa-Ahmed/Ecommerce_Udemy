namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
{
    public void Configure(EntityTypeBuilder<ProductTag> entity)
    {
        entity.ToTable(nameof(ProductTag));

        entity.HasKey(k => k.Id);

        entity.HasIndex(i => new { i.TagId, i.ProductId }).IsUnique();

    }
}