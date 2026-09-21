using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class CertificateRequest : Entity
{
    public Guid RequesterUserId { get; set; }
    public Guid? OrganizationId { get; set; }
    public string Csr { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public AppUser? Requester { get; set; }
    public Organization? Organization { get; set; }
}
