using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class Anchor : Entity
{
    public Guid DocumentId { get; set; }
    public string AnchorType { get; set; } = string.Empty; // e.g., Blockchain, Timestamp, Notary
    public string Reference { get; set; } = string.Empty; // e.g., tx hash or timestamp id
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public Document? Document { get; set; }
}
