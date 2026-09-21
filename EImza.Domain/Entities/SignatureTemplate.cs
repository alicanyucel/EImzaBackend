using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class SignatureTemplate : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string JsonDefinition { get; set; } = string.Empty; // JSON describing signature fields/positions
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public AppUser? CreatedBy { get; set; }
}
