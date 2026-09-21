using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class Certificate : Entity
{
    public string SerialNumber { get; set; } = string.Empty;
    public Guid? AuthorityId { get; set; }
    public Guid? OwnerUserId { get; set; }
    public Guid? OrganizationId { get; set; }
    public DateTime IssuedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
    public bool IsRevoked { get; set; }
    public string? RawDataBase64 { get; set; }
    public CertificateAuthority? Authority { get; set; }
    public AppUser? OwnerUser { get; set; }
    public Organization? Organization { get; set; }
    public ICollection<Signature> Signatures { get; set; } = new List<Signature>();
}
