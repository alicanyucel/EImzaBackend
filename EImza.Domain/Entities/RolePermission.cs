using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class RolePermission : Entity
{
    public Guid RoleId { get; set; } // IdentityRole<Guid>
    public Guid PermissionId { get; set; }

    // Navigation
    public Permission? Permission { get; set; }
}
