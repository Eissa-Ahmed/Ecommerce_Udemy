namespace Ecommerce.Infrastucture.Configurations;

public sealed class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> entity)
    {
        entity.ToTable(nameof(RefreshToken));

        entity.HasKey(k => k.Token);
    }
}
