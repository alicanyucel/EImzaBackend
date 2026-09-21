using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class AnchorConfiguration : IEntityTypeConfiguration<Anchor>
{
    public void Configure(EntityTypeBuilder<Anchor> builder)
    {
        builder.ToTable("Anchors");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.AnchorType).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Reference).IsRequired().HasMaxLength(1000);
        builder.HasIndex(x => x.DocumentId);

        builder.HasOne(x => x.Document)
            .WithMany()
            .HasForeignKey(x => x.DocumentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
