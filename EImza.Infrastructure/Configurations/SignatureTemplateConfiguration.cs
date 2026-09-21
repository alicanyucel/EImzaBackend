using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class SignatureTemplateConfiguration : IEntityTypeConfiguration<SignatureTemplate>
{
    public void Configure(EntityTypeBuilder<SignatureTemplate> builder)
    {
        builder.ToTable("SignatureTemplates");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.JsonDefinition).HasColumnType("nvarchar(max)");

        builder.HasOne(x => x.CreatedBy)
            .WithMany()
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
