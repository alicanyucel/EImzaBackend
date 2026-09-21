using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class Notary : Entity
{
    public string Name { get; set; } = string.Empty;
    public string? RegistrationNumber { get; set; }
    public string? Contact { get; set; }
    public System.Collections.Generic.ICollection<Anchor> Anchors { get; set; } = new System.Collections.Generic.List<Anchor>();
}
