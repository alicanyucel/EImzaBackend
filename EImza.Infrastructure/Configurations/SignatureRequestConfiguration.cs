using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class SignatureRequestConfiguration : IEntityTypeConfiguration<SignatureRequest>
{
    public void Configure(EntityTypeBuilder<SignatureRequest> builder)
    {
        builder.ToTable("SignatureRequests");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Status).HasMaxLength(50);
        builder.Property(x => x.RequestedAt).IsRequired();
        builder.HasOne(x => x.Document)
            .WithMany()
            .HasForeignKey(x => x.DocumentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.RequestedBy)
            .WithMany()
            .HasForeignKey(x => x.RequestedByUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
