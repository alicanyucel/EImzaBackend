using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class SigningSessionConfiguration : IEntityTypeConfiguration<SigningSession>
{
    public void Configure(EntityTypeBuilder<SigningSession> builder)
    {
        builder.ToTable("SigningSessions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.SessionToken).IsRequired().HasMaxLength(500);
        builder.Property(x => x.Status).HasMaxLength(50);

        builder.HasOne(x => x.SignatureRequest)
            .WithMany()
            .HasForeignKey(x => x.SignatureRequestId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
