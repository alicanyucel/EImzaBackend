using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class TimestampTokenConfiguration : IEntityTypeConfiguration<TimestampToken>
{
    public void Configure(EntityTypeBuilder<TimestampToken> builder)
    {
        builder.ToTable("TimestampTokens");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.TokenBase64).IsRequired().HasColumnType("nvarchar(max)");
        builder.HasIndex(x => x.DocumentId);

        builder.HasOne(x => x.CreatedBy)
            .WithMany()
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Document)
            .WithMany()
            .HasForeignKey(x => x.DocumentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
