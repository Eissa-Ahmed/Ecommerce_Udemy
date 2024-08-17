namespace Ecommerce.Infrastucture.Configurations;

public sealed class CodesConfiguration : IEntityTypeConfiguration<Codes>
{
    public void Configure(EntityTypeBuilder<Codes> entity)
    {
        entity.ToTable(nameof(Codes));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Code)
            .IsRequired();

    }
}
