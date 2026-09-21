using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class KeyPairConfiguration : IEntityTypeConfiguration<KeyPair>
{
    public void Configure(EntityTypeBuilder<KeyPair> builder)
    {
        builder.ToTable("KeyPairs");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.KeyType).HasMaxLength(50).IsRequired();
        builder.Property(x => x.PublicKey).IsRequired();
        builder.HasIndex(x => x.OwnerId);
    }
}
