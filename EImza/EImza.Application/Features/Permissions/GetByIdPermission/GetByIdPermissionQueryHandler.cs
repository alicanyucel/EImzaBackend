using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.GetByIdPermission
{
    internal sealed class GetByIdPermissionQueryHandler(
        IPermissionRepository permissionRepository) : IRequestHandler<GetByIdPermissionQuery, Result<Permission>>
    {
        public async Task<Result<Permission>> Handle(GetByIdPermissionQuery request, CancellationToken cancellationToken)
        {
            var permission = await permissionRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (permission is null)
            {
                return (500, "Yetki bulunamadı");
            }

            return permission;
        }
    }
}
