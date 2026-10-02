using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.GetAllPermission
{
    public sealed record GetAllPermissionQuery() : IRequest<Result<List<Permission>>>;
}
