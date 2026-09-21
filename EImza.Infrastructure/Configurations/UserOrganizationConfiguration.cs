using EImza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EImza.Infrastructure.Configurations;

internal sealed class UserOrganizationConfiguration : IEntityTypeConfiguration<UserOrganization>
{
    public void Configure(EntityTypeBuilder<UserOrganization> builder)
    {
        builder.ToTable("UserOrganizations");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Role).HasMaxLength(100);

        builder.HasIndex(x => new { x.UserId, x.OrganizationId }).IsUnique(false);

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Organization)
            .WithMany(o => o.UserOrganizations)
            .HasForeignKey(x => x.OrganizationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
