using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class ValidationResultConfiguration : IEntityTypeConfiguration<ValidationResult>
{
    public void Configure(EntityTypeBuilder<ValidationResult> builder)
    {
        builder.ToTable("ValidationResults");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Details).HasColumnType("nvarchar(max)");
        builder.Property(x => x.IsValid).IsRequired();
        builder.Property(x => x.CheckedAt).IsRequired();

        builder.HasOne(x => x.Signature)
            .WithMany()
            .HasForeignKey(x => x.SignatureId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
