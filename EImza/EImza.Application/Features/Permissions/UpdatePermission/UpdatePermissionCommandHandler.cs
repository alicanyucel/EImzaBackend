using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.UpdatePermission
{
    internal sealed class UpdatePermissionCommandHandler(
        IPermissionRepository permissionRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdatePermissionCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdatePermissionCommand request, CancellationToken cancellationToken)
        {
            var permission = await permissionRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (permission is null)
            {
                return (500, "Yetki bulunamadı");
            }

            permission.Name = request.Name;
            permission.Description = request.Description;

            permissionRepository.Update(permission);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
