using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class Notary : Entity
{
    public string Name { get; set; } = string.Empty;
    public string? RegistrationNumber { get; set; }
    public string? Contact { get; set; }

    // Navigation
    public ICollection<Anchor> Anchors { get; set; } = new List<Anchor>();
}
