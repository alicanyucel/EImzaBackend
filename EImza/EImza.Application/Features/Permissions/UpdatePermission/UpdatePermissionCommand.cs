using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.UpdatePermission
{
    public sealed record UpdatePermissionCommand(
        Guid Id,
        string Name,
        string Description) : IRequest<Result<bool>>;
}
