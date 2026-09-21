using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class Document : Entity
{
    public string FileName { get; set; } = string.Empty;
    public string ContentType { get; set; } = "application/octet-stream";
    public long Size { get; set; }
    public Guid UploadedByUserId { get; set; }
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; }

    // Navigation
    public AppUser? UploadedBy { get; set; }
    public ICollection<DocumentVersion> Versions { get; set; } = new List<DocumentVersion>();
    public ICollection<Signature> Signatures { get; set; } = new List<Signature>();
}
