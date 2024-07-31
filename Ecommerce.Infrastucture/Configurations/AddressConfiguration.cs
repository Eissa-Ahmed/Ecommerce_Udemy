namespace Ecommerce.Infrastucture.Configurations;

public sealed class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> entity)
    {
        entity.ToTable(nameof(Address));

        entity.HasKey(k => k.Id);

    }
}
