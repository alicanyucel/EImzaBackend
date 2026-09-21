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
    public AppUser? UploadedBy { get; set; }
    public System.Collections.Generic.ICollection<DocumentVersion> Versions { get; set; } = new System.Collections.Generic.List<DocumentVersion>();
    public System.Collections.Generic.ICollection<Signature> Signatures { get; set; } = new System.Collections.Generic.List<Signature>();
}
