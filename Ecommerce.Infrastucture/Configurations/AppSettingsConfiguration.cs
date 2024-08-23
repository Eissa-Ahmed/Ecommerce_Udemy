﻿namespace Ecommerce.Infrastucture.Configurations;

public sealed class AppSettingsConfiguration : IEntityTypeConfiguration<AppSettings>
{
    public void Configure(EntityTypeBuilder<AppSettings> entity)
    {
        entity.ToTable(nameof(AppSettings));

        entity.HasKey(k => k.Id);

        entity.Property(p => p.Email)
            .IsRequired();

        entity.Property(p => p.MinimumFreeShipping)
            .HasAnnotation("MinValue", 0);

        entity.HasOne(i => i.SocialMediaAccounts)
            .WithOne(i => i.AppSettings)
            .HasForeignKey<AppSettings>(i => i.SocialMediaAccountsId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
