using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class SignatureRequest : Entity
{
    public Guid DocumentId { get; set; }
    public Guid RequestedByUserId { get; set; }
    public ICollection<Guid> RequestedSignerCertificateIds { get; set; } = new List<Guid>();
    public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ExpiresAt { get; set; }
    public string Status { get; set; } = "Pending"; // Pending, Completed, Cancelled

    // Navigation
    public Document? Document { get; set; }
    public AppUser? RequestedBy { get; set; }
}
