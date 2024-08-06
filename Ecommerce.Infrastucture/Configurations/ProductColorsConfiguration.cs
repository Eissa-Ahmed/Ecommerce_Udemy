namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductColorsConfiguration : IEntityTypeConfiguration<ProductColors>
{
    public void Configure(EntityTypeBuilder<ProductColors> entity)
    {
        entity.ToTable(nameof(ProductColors));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Color)
            .IsRequired();

        entity.Property(i => i.Count)
            .IsRequired();
    }
}