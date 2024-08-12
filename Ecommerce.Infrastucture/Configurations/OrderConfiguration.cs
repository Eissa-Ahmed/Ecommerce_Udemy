namespace Ecommerce.Infrastucture.Configurations;

public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> entity)
    {
        entity.ToTable(nameof(Order));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.OrderDate)
            .IsRequired();

        entity.Property(i => i.TotalAmount)
            .IsRequired();

        entity.Property(p => p.Status)
            .HasConversion(
                v => v.ToString(),
                v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v));

        entity.HasOne(i => i.User)
            .WithMany(i => i.Orders)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity.HasMany(i => i.OrderItems)
            .WithOne(i => i.Order)
            .HasForeignKey(i => i.OrderId)
            .OnDelete(DeleteBehavior.Cascade);


        entity.HasOne(i => i.Payment)
            .WithOne(i => i.Order)
            .HasForeignKey<Order>(i => i.PaymentId)
            .OnDelete(DeleteBehavior.Cascade);


    }
}
