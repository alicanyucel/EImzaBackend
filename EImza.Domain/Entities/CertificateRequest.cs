using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class CertificateRequest : Entity
{
    public Guid RequesterUserId { get; set; }
    public Guid? OrganizationId { get; set; }
    public string Csr { get; set; } = string.Empty; // PEM/PKCS10 CSR
    public string Status { get; set; } = "Pending"; // Pending, Issued, Rejected
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public AppUser? Requester { get; set; }
    public Organization? Organization { get; set; }
}
