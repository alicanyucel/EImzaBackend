using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class Anchor : Entity
{
    public Guid DocumentId { get; set; }
    public string AnchorType { get; set; } = string.Empty;
    public string Reference { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Document? Document { get; set; }
}
