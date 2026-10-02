using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.DeletePermission
{
    public sealed record DeletePermissionCommand(Guid Id) : IRequest<Result<bool>>;
}
