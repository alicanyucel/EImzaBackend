using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class DocumentVersionConfiguration : IEntityTypeConfiguration<DocumentVersion>
{
    public void Configure(EntityTypeBuilder<DocumentVersion> builder)
    {
        builder.ToTable("DocumentVersions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.BlobStoragePath).IsRequired().HasMaxLength(1000);
        builder.HasIndex(x => new { x.DocumentId, x.VersionNumber }).IsUnique();

        builder.HasOne(x => x.Document)
            .WithMany(d => d.Versions)
            .HasForeignKey(x => x.DocumentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.CreatedBy)
            .WithMany()
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
