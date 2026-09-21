using EImza.Domain.Entities;
using GenericRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EImza.Infrastructure.Context
{
    internal sealed class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; } = null!;
        public DbSet<UserOrganization> UserOrganizations { get; set; } = null!;
        public DbSet<CertificateAuthority> CertificateAuthorities { get; set; } = null!;
        public DbSet<KeyPair> KeyPairs { get; set; } = null!;
        public DbSet<Certificate> Certificates { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;
        public DbSet<DocumentVersion> DocumentVersions { get; set; } = null!;
        public DbSet<Signature> Signatures { get; set; } = null!;
        public DbSet<SignatureRequest> SignatureRequests { get; set; } = null!;
        public DbSet<SignatureTemplate> SignatureTemplates { get; set; } = null!;
        public DbSet<SigningSession> SigningSessions { get; set; } = null!;
        public DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public DbSet<ApiKey> ApiKeys { get; set; } = null!;
        public DbSet<CertificateRequest> CertificateRequests { get; set; } = null!;
        public DbSet<TimestampToken> TimestampTokens { get; set; } = null!;
        public DbSet<ValidationResult> ValidationResults { get; set; } = null!;
        public DbSet<Anchor> Anchors { get; set; } = null!;
        public DbSet<Notary> Notaries { get; set; } = null!;
        public DbSet<Permission> Permissions { get; set; } = null!;
        public DbSet<RolePermission> RolePermissions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(DependencyInjection).Assembly);

            builder.Ignore<IdentityUserLogin<Guid>>();
            builder.Ignore<IdentityRoleClaim<Guid>>();
            builder.Ignore<IdentityUserToken<Guid>>();
            builder.Ignore<IdentityUserRole<Guid>>();
            builder.Ignore<IdentityUserClaim<Guid>>();
        }
    }
}
