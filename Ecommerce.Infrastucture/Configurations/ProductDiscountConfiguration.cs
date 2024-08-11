namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductDiscountConfiguration : IEntityTypeConfiguration<ProductDiscount>
{
    public void Configure(EntityTypeBuilder<ProductDiscount> entity)
    {
        entity.ToTable(nameof(ProductDiscount));

        entity.HasKey(k => k.Id);
    }
}
