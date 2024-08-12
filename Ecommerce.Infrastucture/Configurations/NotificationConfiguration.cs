namespace Ecommerce.Infrastucture.Configurations;

public sealed class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> entity)
    {
        entity.ToTable(nameof(Notification));

        entity.HasKey(k => k.Id);

        entity.Property(p => p.Message)
            .IsRequired()
            .HasMaxLength(100);

        entity.Property(p => p.NotificationType)
            .HasConversion(
                v => v.ToString(),
                v => (NotificationType)Enum.Parse(typeof(NotificationType), v));


    }
}