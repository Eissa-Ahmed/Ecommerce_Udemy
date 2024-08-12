namespace Ecommerce.Infrastucture.Configurations;

public sealed class WishlistItemConfiguration : IEntityTypeConfiguration<WishlistItem>
{
    public void Configure(EntityTypeBuilder<WishlistItem> entity)
    {
        entity.ToTable(nameof(WishlistItem));

        entity.HasKey(k => k.Id);

    }
}