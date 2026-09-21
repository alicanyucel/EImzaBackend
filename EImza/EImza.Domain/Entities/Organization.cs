using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;

public sealed class Organization : Entity
{
    public string Name { get; set; } = string.Empty;
    public string? TaxId { get; set; }
    public string? Address { get; set; }
    public string? ContactEmail { get; set; }
    public bool IsActive { get; set; } = true;
    public ICollection<UserOrganization> UserOrganizations { get; set; } = new List<UserOrganization>();
    public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
}
