namespace Ecommerce.Infrastucture.Configurations;

public sealed class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> entity)
    {
        entity.ToTable(nameof(Subscription));

        entity.HasKey(k => k.Id);

        entity.HasIndex(i => i.UserId).IsUnique();

    }
}
