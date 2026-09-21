using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class Permission : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
