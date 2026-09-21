using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class DocumentVersion : Entity
{
    public Guid DocumentId { get; set; }
    public int VersionNumber { get; set; }
    public string BlobStoragePath { get; set; } = string.Empty; // pointer to actual data
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Guid CreatedByUserId { get; set; }

    // Navigation
    public Document? Document { get; set; }
    public AppUser? CreatedBy { get; set; }
}
