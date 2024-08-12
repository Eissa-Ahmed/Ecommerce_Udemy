namespace Ecommerce.Infrastucture.Configurations;

public sealed class Paymentfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> entity)
    {
        entity.ToTable(nameof(Order));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Amount)
            .IsRequired();

        entity.Property(p => p.PaymentStatus)
            .HasConversion(
                v => v.ToString(),
                v => (PaymentStatus)Enum.Parse(typeof(PaymentStatus), v));

        entity.HasOne(i => i.PaymentMethod)
                   .WithOne()
                   .HasForeignKey<Payment>(i => i.PaymentMethodId)
                   .OnDelete(DeleteBehavior.Cascade);


    }
}
