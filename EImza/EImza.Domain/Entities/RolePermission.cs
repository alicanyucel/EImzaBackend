using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class RolePermission : Entity
{
    public Guid RoleId { get; set; }
    public Guid PermissionId { get; set; }
    public Permission? Permission { get; set; }
}
