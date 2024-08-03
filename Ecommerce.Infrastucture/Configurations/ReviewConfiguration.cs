namespace Ecommerce.Infrastucture.Configurations;

public sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> entity)
    {
        entity.ToTable(nameof(Review));

        entity.HasKey(k => k.Id);
        entity.HasIndex(i => new { i.ProductId, i.UserId }).IsUnique();

    }
}
