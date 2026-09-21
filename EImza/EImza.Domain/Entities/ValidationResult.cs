using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class ValidationResult : Entity
{
    public Guid SignatureId { get; set; }
    public bool IsValid { get; set; }
    public string Details { get; set; } = string.Empty;
    public DateTime CheckedAt { get; set; } = DateTime.UtcNow;
    public Signature? Signature { get; set; }
}
