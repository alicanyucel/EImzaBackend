using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class CertificateAuthorityConfiguration : IEntityTypeConfiguration<CertificateAuthority>
{
    public void Configure(EntityTypeBuilder<CertificateAuthority> builder)
    {
        builder.ToTable("CertificateAuthorities");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Url).HasMaxLength(500);
    }
}
