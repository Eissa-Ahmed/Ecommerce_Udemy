namespace Ecommerce.Infrastucture.Configurations;

public sealed class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> entity)
    {
        entity.ToTable(nameof(Tag));

        entity.HasKey(k => k.Id);

        entity.Property(p => p.TagName)
            .IsRequired()
            .HasMaxLength(25);

    }
}
