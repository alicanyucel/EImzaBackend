using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class SignatureConfiguration : IEntityTypeConfiguration<Signature>
{
    public void Configure(EntityTypeBuilder<Signature> builder)
    {
        builder.ToTable("Signatures");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.SignatureValue).IsRequired().HasColumnType("nvarchar(max)");
        builder.Property(x => x.Status).HasMaxLength(50);

        builder.HasOne(x => x.Document)
            .WithMany(d => d.Signatures)
            .HasForeignKey(x => x.DocumentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.DocumentVersion)
            .WithMany()
            .HasForeignKey(x => x.DocumentVersionId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(x => x.Certificate)
            .WithMany(c => c.Signatures)
            .HasForeignKey(x => x.CertificateId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
