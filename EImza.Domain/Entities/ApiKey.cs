using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class ApiKey : Entity
{
    public string Name { get; set; } = string.Empty;
    public string KeyHash { get; set; } = string.Empty;
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ExpiresAt { get; set; }
    public bool IsRevoked { get; set; }

    // Navigation
    public AppUser? CreatedBy { get; set; }
}
