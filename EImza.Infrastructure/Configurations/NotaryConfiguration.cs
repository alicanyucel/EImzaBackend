using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class NotaryConfiguration : IEntityTypeConfiguration<Notary>
{
    public void Configure(EntityTypeBuilder<Notary> builder)
    {
        builder.ToTable("Notaries");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.RegistrationNumber).HasMaxLength(200);
    }
}
