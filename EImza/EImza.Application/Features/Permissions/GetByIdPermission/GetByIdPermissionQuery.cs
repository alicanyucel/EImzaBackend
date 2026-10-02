using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.GetByIdPermission
{
    public sealed record GetByIdPermissionQuery(Guid Id) : IRequest<Result<Permission>>;
}
