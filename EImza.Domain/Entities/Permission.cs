using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class Permission : Entity
{
    public string Name { get; set; } = string.Empty; // e.g., Documents.View
    public string Description { get; set; } = string.Empty;
}
