namespace Ecommerce.Infrastucture.Configurations;

public sealed class FeaturesConfiguration : IEntityTypeConfiguration<Features>
{
    public void Configure(EntityTypeBuilder<Features> entity)
    {
        entity.ToTable(nameof(Features));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Text)
            .IsRequired()
            .HasMaxLength(500);
    }
}
