using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
{
    public void Configure(EntityTypeBuilder<Certificate> builder)
    {
        builder.ToTable("Certificates");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.SerialNumber).IsRequired().HasMaxLength(200);
        builder.Property(x => x.RawDataBase64).HasColumnType("nvarchar(max)");
        builder.HasIndex(x => x.SerialNumber).IsUnique();

        builder.HasOne(x => x.Authority)
            .WithMany(a => a.Certificates)
            .HasForeignKey(x => x.AuthorityId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(x => x.OwnerUser)
            .WithMany()
            .HasForeignKey(x => x.OwnerUserId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(x => x.Organization)
            .WithMany(o => o.Certificates)
            .HasForeignKey(x => x.OrganizationId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
