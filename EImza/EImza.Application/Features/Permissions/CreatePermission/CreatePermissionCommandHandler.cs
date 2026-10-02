using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.CreatePermission
{
    internal sealed class CreatePermissionCommandHandler(
        IPermissionRepository permissionRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreatePermissionCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {
            var permission = new Permission
            {
                Name = request.Name,
                Description = request.Description
            };

            await permissionRepository.AddAsync(permission, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return permission.Id;
        }
    }
}
