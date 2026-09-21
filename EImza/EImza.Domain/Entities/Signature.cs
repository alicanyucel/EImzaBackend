using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class Signature : Entity
{
    public Guid DocumentId { get; set; }
    public Guid? DocumentVersionId { get; set; }
    public Guid CertificateId { get; set; }
    public DateTime SignedAt { get; set; } = DateTime.UtcNow;
    public string SignatureValue { get; set; } = string.Empty;
    public string Status { get; set; } = "Signed";
    public string? Reason { get; set; }
    public Document? Document { get; set; }
    public DocumentVersion? DocumentVersion { get; set; }
    public Certificate? Certificate { get; set; }
}
