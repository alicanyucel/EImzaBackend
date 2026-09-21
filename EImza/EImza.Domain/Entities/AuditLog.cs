using EImza.Domain.Abstractions;
using EImza.Domain.Entities;

public sealed class AuditLog : Entity
{
    public string EntityName { get; set; } = string.Empty;
    public Guid? EntityId { get; set; }
    public string Action { get; set; } = string.Empty;
    public string Data { get; set; } = string.Empty;
    public Guid? PerformedByUserId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public AppUser? PerformedBy { get; set; }
}
