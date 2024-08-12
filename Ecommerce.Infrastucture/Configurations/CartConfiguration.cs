namespace Ecommerce.Infrastucture.Configurations;

public sealed class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> entity)
    {
        entity.ToTable(nameof(Cart));

        entity.HasKey(k => k.Id);

        entity.HasMany(i => i.CartItems)
            .WithOne(i => i.Cart)
            .HasForeignKey(i => i.CartId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
