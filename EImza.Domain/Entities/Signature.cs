using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class Signature : Entity
{
    public Guid DocumentId { get; set; }
    public Guid? DocumentVersionId { get; set; }
    public Guid CertificateId { get; set; }
    public DateTime SignedAt { get; set; } = DateTime.UtcNow;
    public string SignatureValue { get; set; } = string.Empty; // base64 or detached
    public string Status { get; set; } = "Signed"; // Signed, Verified, Invalid, Revoked
    public string? Reason { get; set; }

    // Navigation
    public Document? Document { get; set; }
    public DocumentVersion? DocumentVersion { get; set; }
    public Certificate? Certificate { get; set; }
}
