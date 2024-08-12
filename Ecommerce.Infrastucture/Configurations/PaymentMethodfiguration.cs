namespace Ecommerce.Infrastucture.Configurations;

public sealed class PaymentMethodfiguration : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> entity)
    {
        entity.ToTable(nameof(PaymentMethod));

        entity.HasKey(k => k.Id);

        entity.Property(p => p.Name)
            .HasConversion(
                v => v.ToString(),
                v => (PaymentMethodName)Enum.Parse(typeof(PaymentMethodName), v));

    }
}