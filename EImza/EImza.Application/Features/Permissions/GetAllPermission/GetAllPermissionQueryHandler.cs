using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.Permissions.GetAllPermission
{
    internal sealed class GetAllPermissionQueryHandler(
        IPermissionRepository permissionRepository) : IRequestHandler<GetAllPermissionQuery, Result<List<Permission>>>
    {
        public async Task<Result<List<Permission>>> Handle(GetAllPermissionQuery request, CancellationToken cancellationToken)
        {
            var permissions = await permissionRepository.GetAll()
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

            return permissions;
        }
    }
}
