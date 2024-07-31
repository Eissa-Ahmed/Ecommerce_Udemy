namespace Ecommerce.Infrastucture.Configurations;

public sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> entity)
    {
        entity.ToTable(nameof(Review));

        entity.HasKey(k => new { k.ProductId, k.UserId });

    }
}
