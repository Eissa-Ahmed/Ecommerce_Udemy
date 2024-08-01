namespace Ecommerce.Infrastucture.Configurations;

public sealed class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> entity)
    {
        entity.ToTable(nameof(Address));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Address1)
            .IsRequired()
            .HasMaxLength(250);

        entity.Property(i => i.City)
            .IsRequired();

        entity.Property(i => i.State)
            .IsRequired();

        entity.Property(i => i.Country)
            .IsRequired();
    }
}
