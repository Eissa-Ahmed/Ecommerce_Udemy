namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttributes>
{
    public void Configure(EntityTypeBuilder<ProductAttributes> entity)
    {
        entity.ToTable(nameof(ProductAttributes));

        entity.HasKey(k => new { k.ProductId, k.AttributeName });

        entity
            .HasOne(o => o.Product)
            .WithMany()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
