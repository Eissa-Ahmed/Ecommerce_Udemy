namespace Ecommerce.Infrastucture.Configurations;

public sealed class WishlistConfiguration : IEntityTypeConfiguration<Wishlist>
{
    public void Configure(EntityTypeBuilder<Wishlist> entity)
    {
        entity.ToTable(nameof(Wishlist));

        entity.HasKey(k => k.Id);


        entity
            .HasMany(o => o.WishlistItems)
            .WithOne(o => o.Wishlist)
            .HasForeignKey(i => i.WishlistId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
