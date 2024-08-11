namespace Ecommerce.Infrastucture.Configurations;

public sealed class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> entity)
    {
        entity.ToTable(nameof(CartItem));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Quantity)
            .IsRequired()
            .HasAnnotation("MinValue", 1);
    }
}
