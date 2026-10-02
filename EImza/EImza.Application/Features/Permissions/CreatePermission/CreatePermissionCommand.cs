using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.CreatePermission
{
    public sealed record CreatePermissionCommand(
        string Name,
        string Description) : IRequest<Result<Guid>>;
}
