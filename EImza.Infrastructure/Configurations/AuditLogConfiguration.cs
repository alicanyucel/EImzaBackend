using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
{
    public void Configure(EntityTypeBuilder<AuditLog> builder)
    {
        builder.ToTable("AuditLogs");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.EntityName).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Action).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Data).HasColumnType("nvarchar(max)");
        builder.HasIndex(x => x.PerformedByUserId);
    }
}
