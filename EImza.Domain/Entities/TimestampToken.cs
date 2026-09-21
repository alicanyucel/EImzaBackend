using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class TimestampToken : Entity
{
    public string TokenBase64 { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Guid CreatedByUserId { get; set; }
    public Guid DocumentId { get; set; }

    // Navigation
    public AppUser? CreatedBy { get; set; }
    public Document? Document { get; set; }
}
