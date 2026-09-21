using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class SigningSession : Entity
{
    public Guid SignatureRequestId { get; set; }
    public Guid SignerCertificateId { get; set; }
    public string SessionToken { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime ExpiresAt { get; set; }
    public string Status { get; set; } = "Pending";
    public SignatureRequest? SignatureRequest { get; set; }
}
