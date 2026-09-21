using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class UserOrganization : Entity
{
    public Guid UserId { get; set; }
    public Guid OrganizationId { get; set; }
    public string Role { get; set; } = string.Empty;
    public AppUser? User { get; set; }
    public Organization? Organization { get; set; }
}
