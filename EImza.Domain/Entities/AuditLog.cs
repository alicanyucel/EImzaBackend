using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class AuditLog : Entity
{
    public string EntityName { get; set; } = string.Empty;
    public Guid? EntityId { get; set; }
    public string Action { get; set; } = string.Empty; // Create, Update, Delete
    public string Data { get; set; } = string.Empty; // JSON payload
    public Guid? PerformedByUserId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public AppUser? PerformedBy { get; set; }
}
