using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class CertificateRequestConfiguration : IEntityTypeConfiguration<CertificateRequest>
{
    public void Configure(EntityTypeBuilder<CertificateRequest> builder)
    {
        builder.ToTable("CertificateRequests");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Csr).IsRequired().HasColumnType("nvarchar(max)");
        builder.Property(x => x.Status).HasMaxLength(50);
        builder.HasOne(x => x.Requester)
            .WithMany()
            .HasForeignKey(x => x.RequesterUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Organization)
            .WithMany()
            .HasForeignKey(x => x.OrganizationId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
