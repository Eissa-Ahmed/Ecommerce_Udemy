namespace Ecommerce.Infrastucture.Configurations;

public sealed class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> entity)
    {
        entity.ToTable(nameof(OrderItem));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Name)
            .IsRequired();

        entity.Property(i => i.MainImage)
            .IsRequired();

        entity.Property(i => i.Quantity)
            .IsRequired()
            .HasAnnotation("MinValue", 1);

        entity.Property(i => i.TotalPrice)
            .IsRequired();
    }
}
