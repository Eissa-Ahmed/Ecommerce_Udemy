namespace Ecommerce.Infrastucture.Configurations;

public sealed class CustomerSupportTicketConfiguration : IEntityTypeConfiguration<CustomerSupportTicket>
{
    public void Configure(EntityTypeBuilder<CustomerSupportTicket> entity)
    {
        entity.ToTable(nameof(CustomerSupportTicket));

        entity.HasKey(k => k.Id);

        entity.Property(p => p.Subject)
            .IsRequired()
            .HasMaxLength(100);

        entity.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(500);

        entity.Property(p => p.Status)
            .HasConversion(
                v => v.ToString(),
                v => (TicketStatus)Enum.Parse(typeof(TicketStatus), v));


    }
}