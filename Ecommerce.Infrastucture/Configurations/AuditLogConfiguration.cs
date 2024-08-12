namespace Ecommerce.Infrastucture.Configurations;

public sealed class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
{
    public void Configure(EntityTypeBuilder<AuditLog> entity)
    {
        entity.ToTable(nameof(AuditLog));

        entity.HasKey(k => k.Id);

        entity.Property(p => p.Action)
            .IsRequired();

        entity.Property(p => p.EntityName)
            .IsRequired();

        entity.Property(p => p.EntityId)
            .IsRequired();

        entity.Property(p => p.DateLogged)
            .IsRequired();
    }
}